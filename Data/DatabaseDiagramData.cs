﻿using DevExpress.Data.Filtering;
using DevExpress.Diagram.Core;
using DiagramMainDemo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Xml.Serialization;

namespace DevExpress.Diagram.Demos {
    public static class DatabaseData {
        public static DatabaseDefinition GetDatabaseDefinition() {

            DBAccess db = new DBAccess();
            string sQuery = "SELECT * FROM SchemaItems ";
            DataTable dtItems = db.ExecuteDataTableText(sQuery);

            DatabaseDefinition databaseDefinition = new DatabaseDefinition();
            
            List<string> lstCols = new List<string>();
            int iTableNum = 0;
            int iPosX = 0,iPosY=0;
            foreach (DataRow dr1 in dtItems.Rows)
            {
                TableDefinition tableDefinition1 = new TableDefinition();
                ConnectionDefinition connectionDefinition = null;
                string sTableName = dr1["TableName"].ToString();
                if (!lstCols.Contains(sTableName))
                {
                    iTableNum++;
                   

                  
                    tableDefinition1.Name = sTableName;
                    List<DataRow> drsColumns = dtItems.AsEnumerable().Where(a => a.Field<string>("TableName") == sTableName).ToList();
                    foreach (DataRow drCol in drsColumns)
                    {
                        ColumnDefinition columnDefinition = new ColumnDefinition();
                        
                        columnDefinition.TableName = sTableName;
                        columnDefinition.Name = drCol["ColumnName"].ToString();
                        if(bool.Parse(drCol["IsPrimaryKey"].ToString()))
                        {
                            columnDefinition.IsPrimaryKey = true;
                        }
                        if(bool.Parse(drCol["IsForeignKey"].ToString()))
                        {
                            connectionDefinition = new ConnectionDefinition();
                            //dtItems.AsEnumerable().Where(a => a.Field<string>("TableName") == sTableName && a.Field<bool>("IsPrimaryKey"))
                            connectionDefinition.ToRelation = TableRelation.Many;
                            connectionDefinition.FromRelation = TableRelation.One;
                            connectionDefinition.From = drCol["RelatedTable"].ToString() + "."+ drCol["ColumnName"].ToString();
                            connectionDefinition.To = sTableName + "." + drCol["ColumnName"].ToString();

                        }
                        tableDefinition1.Columns.Add(columnDefinition);
                    }
                    tableDefinition1.PositionX = iPosX;
                    tableDefinition1.PositionY = iPosY;
                    iPosX += 250;
                    if (iPosX >= 1000)
                    {
                        //each column got 35 Pos in Y
                        iPosX = 0;
                        iPosY += 80 * drsColumns.Count;
                        //if (drsColumns.Count>20)
                        //{
                        //    iPosY += 300;
                        //}
                        
                    }

                    lstCols.Add(sTableName);
                    databaseDefinition.Tables.Add(tableDefinition1);
                    if(connectionDefinition!=null)
                    {
                        //databaseDefinition.Connections.Add(connectionDefinition);
                    }
                    
                }
            }
            return databaseDefinition;

            //using (var stream = DiagramDemoFileHelper.GetDataStream("DatabaseDiagram.xml")) {
            //    var serializer = new XmlSerializer(typeof(DatabaseDefinition));
            //    return (DatabaseDefinition)serializer.Deserialize(stream);
            //}
        }
    }

    [XmlInclude(typeof(TableDefinition)), XmlInclude(typeof(ConnectionDefinition))]
    [XmlRoot("Database")]
    public class DatabaseDefinition {
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlArray("Tables"), XmlArrayItem(typeof(TableDefinition))]
        public Collection<TableDefinition> Tables { get; private set; }
        [XmlArray("Connections"), XmlArrayItem(typeof(ConnectionDefinition))]
        public Collection<ConnectionDefinition> Connections { get; private set; }

        public TableDefinition this[string tableName] {
            get {
                if(string.IsNullOrEmpty(tableName))
                    throw new ArgumentException("tableName");
                return Tables.SingleOrDefault(x => string.Equals(x.Name, tableName));
            }
        }

        public DatabaseDefinition()
            : this(Enumerable.Empty<TableDefinition>(), Enumerable.Empty<ConnectionDefinition>()) {
        }
        public DatabaseDefinition(IEnumerable<TableDefinition> tables, IEnumerable<ConnectionDefinition> connections) {
            Tables = new Collection<TableDefinition>(tables.ToList());
            Connections = new Collection<ConnectionDefinition>(connections.ToList());
        }
    }
    [XmlInclude(typeof(ColumnDefinition))]
    public class TableDefinition {
        [XmlArray("Columns")]
        [XmlArrayItem(typeof(ColumnDefinition))]
        public Collection<ColumnDefinition> Columns { get; private set; }
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("PositionX")]
        public int PositionX { get; set; }
        [XmlAttribute("PositionY")]
        public int PositionY { get; set; }

        public ColumnDefinition this[string columnName] {
            get {
                if(string.IsNullOrEmpty(columnName))
                    throw new ArgumentException("columnName");
                return Columns.SingleOrDefault(x => string.Equals(x.Name, columnName));
            }
        }
        public TableDefinition()
            : this(Enumerable.Empty<ColumnDefinition>()) {
        }
        public TableDefinition(IEnumerable<ColumnDefinition> columns) {
            Columns = new Collection<ColumnDefinition>(columns.ToList());
        }
    }
    public class ColumnDefinition {
        [XmlAttribute("TableName")]
        public string TableName { get; set; }
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("IsPrimaryKey")]
        public bool IsPrimaryKey { get; set; }
        [XmlIgnore]
        public string Id { get { return string.Join(".", TableName, Name); } }
    }
    [XmlInclude(typeof(TableRelation))]
    public class ConnectionDefinition {
        [XmlAttribute("From")]
        public string From { get; set; }
        [XmlAttribute("To")]
        public string To { get; set; }
        [XmlAttribute("FromRelation")]
        public TableRelation FromRelation { get; set; }
        [XmlAttribute("ToRelation")]
        public TableRelation ToRelation { get; set; }

        public ConnectionDefinition(ColumnDefinition from, ColumnDefinition to) {
            From = from.Id;
            To = to.Id;
        }
        public ConnectionDefinition() { }
    }

    public enum TableRelation {
        One,
        Many
    }

    public class DatabaseDefinitionKeySelector : IKeySelector {
        object IKeySelector.GetKey(object obj) {
            if(obj is TableDefinition)
                return ((TableDefinition)obj).Name;
            else if(obj is ColumnDefinition)
                return ((ColumnDefinition)obj).Id;
            return obj;
        }
    }

    public class TableRelationEvaluationOperator : ICustomFunctionOperator {
        string ICustomFunctionOperator.Name { get { return "TableRelation"; } }

        object ICustomFunctionOperator.Evaluate(params object[] operands) {
            switch((TableRelation)operands[0]) {
                case TableRelation.One:
                    return "1";
                case TableRelation.Many:
                    return "*";
            }
            throw new ArgumentException();
        }

        Type ICustomFunctionOperator.ResultType(params Type[] operands) {
            return typeof(string);
        }
    }
}

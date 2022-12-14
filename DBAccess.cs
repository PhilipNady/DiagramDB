//using DevExpress.XtraDiagram.Demos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;


namespace DiagramMainDemo
{
    internal class DBAccess
    {
        private string sConnectionString = "";
        public DBAccess()
        {
            
            string s1= GetDataFileName("Data\\Diagram\\" + "Project.sdf");
            sConnectionString = "Data Source=" + s1;

        }
        public static string GetRelativeFilePath(string filePathAndName)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
#if DEBUG
            startupPath = Directory.GetParent(startupPath).Parent.FullName + "\\"+ filePathAndName;
#endif
            return startupPath;
            
        }

        public static string GetDataFileName(string filePathAndName)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
#if DEBUG
            startupPath = Directory.GetParent(startupPath).Parent.FullName+"\\";
#endif

           // if (File.Exists(startupPath + filePathAndName))
            {
                return FilesHelper.FindingFileName(startupPath, filePathAndName);
            }
            return "";
        }
        public DataTable ExecuteDataTableText(string sQuery, Dictionary<string, object> dicParams = null, int? iCommandTimeout = null)
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();

            DataTable dt = new DataTable();
            using (SqlCeConnection conn = new SqlCeConnection(sConnectionString))
            using (SqlCeCommand command = new SqlCeCommand(sQuery, conn))
            {
                if (dicParams != null)
                {

                    foreach (KeyValuePair<string, object> keyval1 in dicParams)
                    {

                        SqlParameter param = new SqlParameter(keyval1.Key, keyval1.Value);
                        command.Parameters.Add(param);
                    }
                }
                if (iCommandTimeout.HasValue)
                {
                    command.CommandTimeout = iCommandTimeout.Value;
                }
                using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    dataAdapter.Fill(dt);
                //Added table name to allow serialize the DataTable
                dt.TableName = "Table";
                sw.Stop();
                if (sw.ElapsedMilliseconds >= 30000)
                {
                    bool IsLogIt = false;
                    if (iCommandTimeout.HasValue)
                    {
                        if (sw.ElapsedMilliseconds > iCommandTimeout.Value * 1000)
                        {
                            IsLogIt = true;
                        }
                    }
                    else
                    {
                        IsLogIt = true;
                    }
                    if (IsLogIt)
                    {
                       
                    }
                }
            }
            return dt;

        }


    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace CourseGradingWebService
{
    public class DBHelper
    {
        SqlConnection myConn;
        private static readonly string FOLDER_PATH_LOG = @"D:\mlog.txt";

        private void ConnectionOpen()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultDB"].ConnectionString;
            myConn = new SqlConnection(connectionString);
            myConn.Open();
        }

        private void ConnectionClose()
        {
            myConn.Close();
        }

        public string ExecuteScalar(string query)
        {
            string firstValueOnly = "";
            try
            {
                ConnectionOpen();
                SqlCommand command = new SqlCommand(query, myConn);
                object o  = command.ExecuteScalar();

                try
                {
                    firstValueOnly = o.ToString();
                }
                catch
                {
                }

                ConnectionClose();
            }
            catch (Exception ex)
            {
                
            }
            return firstValueOnly;
        }

        public DataTable ExecuteDataTable(string query)
        {
            ConnectionOpen();
            SqlCommand command = new SqlCommand(query, myConn);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("StudentName");
            dt.Columns.Add("Gender");
            dt.Columns.Add("AdmissionYear");

            while (reader.Read())
            {
                dt.Rows.Add(reader["StudentName"], reader["Gender"], reader["AdmissionYear"]);
            }

            ConnectionClose();
            return dt;
        }

        public bool ExecuteNonQuery(string query)
        {
            bool bReturn = false;
            try
            {
                ConnectionOpen();
                SqlCommand command = new SqlCommand(query, myConn);
                int count = command.ExecuteNonQuery();
                if (count > 0)
                    bReturn = true;
                else
                    bReturn = false;

                ConnectionClose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return bReturn;
        }

        public List<String> ExecuteDataReader(string query)
        {
            List<string> result = new List<string>();


            ConnectionOpen();
            using (SqlCommand command = new SqlCommand(query, myConn))
            {
                command.CommandType = CommandType.Text;
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(reader.GetString(0));
                        }

                        reader.Close();
                    }
                    command.Cancel();
                }
                catch(Exception e)
                {
                    LogService("This is the error" + e.Message);
                }
            }
            ConnectionClose();
            return result;
        }

        public List<int> ExecuteDataReaderInt(string query)
        {
            List<int> result = new List<int>();


            ConnectionOpen();
            using (SqlCommand command = new SqlCommand(query, myConn))
            {
                command.CommandType = CommandType.Text;
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(reader.GetInt32(0));
                        }

                        reader.Close();
                    }
                    command.Cancel();
                }
                catch (Exception e)
                {
                    LogService("This is the error" + e.Message);
                }
            }
            ConnectionClose();
            return result;
        }

        public DataSet ExecuteDataAdapter(string query)
        {
            ConnectionOpen();
            DataSet ds = new DataSet();
            using (SqlDataAdapter a = new SqlDataAdapter(
                    query, myConn))
            {
                a.Fill(ds);
            }
            ConnectionClose();
            return ds;
        }

        private static void LogService(string content)
        {
            try
            {


                FileStream fs = new FileStream(FOLDER_PATH_LOG, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.BaseStream.Seek(0, SeekOrigin.End);
                sw.WriteLine(content);
                sw.Flush();
                sw.Close();
            }
            catch (Exception e)
            {

            }
        }
    }
}
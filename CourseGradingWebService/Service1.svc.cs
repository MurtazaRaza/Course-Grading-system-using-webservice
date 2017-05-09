using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CourseGradingWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static readonly string FOLDER_PATH = @"D:\";
        private static readonly string FOLDER_PATH_LOG = @"D:\M2log.txt";

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public bool ExecuteQuery(String query)
        {
            DBHelper db = new DBHelper();
            return db.ExecuteNonQuery(query);
        }

        public String ExecuteScalerQuery(String query)
        {
            DBHelper db = new DBHelper();
            return db.ExecuteScalar(query);
        }

        public List<String> ExecuteQueryReturningMultiple(string query)
        {
            DBHelper db = new DBHelper();
            return db.ExecuteDataReader(query);
        }

        public List<int> ExecuteQueryReturningMultipleInt(string query)
        {
            DBHelper db = new DBHelper();
            return db.ExecuteDataReaderInt(query);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
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

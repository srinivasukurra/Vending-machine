using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace VendingMachine.cs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }        
    }
    public class customefunctions
    {
        public string sqlSdate(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd 00:00:00.000").ToString();
        }
        public string rs2converter(string str2)
        {
            try
            {
                string str = "";
                str = String.Format("{0:0.00}", Convert.ToDouble(str2));
                return (str);
            }
            catch (Exception ee) { return ("0.00"); }
        }

        public void ExecuteData(string sa)
        {
            try
            {
                using (SqlConnection scn = new SqlConnection(ConfigurationManager.ConnectionStrings["VendingMachine"].ConnectionString))
                {
                    scn.Open();
                    SqlCommand scd = new SqlCommand(sa, scn);
                    scd.ExecuteNonQuery();
                }
            }
            catch (Exception ee) { }
        }

        public string ReturnData(string sa)
        {
            string _retData = string.Empty;
            try
            {                
                using (SqlConnection scn = new SqlConnection(ConfigurationManager.ConnectionStrings["VendingMachine"].ConnectionString))
                {
                    scn.Open();
                    SqlCommand scd = new SqlCommand(sa, scn);
                    SqlDataReader sdr = scd.ExecuteReader();
                    if (sdr.Read())
                    {
                        _retData = sdr[0].ToString();
                    }
                    sdr.Close();
                }                
            }
            catch (Exception ee) { }
            return _retData;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace CSCI3321_ASPNET_FinalProject
{
    public static class SQLquery
    {
        public static void RunQuery(string inputText)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = inputText;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        
        
    }
}
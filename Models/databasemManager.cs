using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System .Data; 
using System.Data.SqlClient;

namespace myproject.Models
{
    public class databasemManager
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T3B0CAK;Initial Catalog=summer21Net;Integrated Security=True");
        SqlCommand cmd = null;
        DataTable dt = null;
        public bool MyInsertUpdateDelete(string command)
        {
            cmd = new SqlCommand(command, con);
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
          int n = cmd.ExecuteNonQuery();
            if (n > 0)
                return true;
            else
                return false;
        }
        public DataTable GetAllRecords(string command)
        {
            dt = new DataTable();
            cmd = new SqlCommand(command, con);
            SqlDataAdapter sa = new SqlDataAdapter(command, con);
            sa.Fill(dt);
            return dt;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18600187_VuCaoNguyen
{
    public class DBConnect
    {
        protected SqlConnection con = new SqlConnection("Server=.\\SQLEXPRESS;database=HANGHOA;Trusted_Connection=True");

        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public DataTable loadData(string strSQL)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd.Connection = con;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;

            OpenConnection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}

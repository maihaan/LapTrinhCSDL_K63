using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLBanHangK63.Controller
{
    public class DataAccess
    {
        String connectionString = Properties.Settings.Default.myConnection;

        public void Write(String tenProcedure, List<SqlParameter> dsThamSo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = tenProcedure;
            foreach (SqlParameter para in dsThamSo)
                cmd.Parameters.Add(para);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch { }
        }

        public DataTable Read(String tenProcedure, List<SqlParameter> dsThamSo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = tenProcedure;
            foreach (SqlParameter para in dsThamSo)
                cmd.Parameters.Add(para);
            try
            {
                connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(dataReader, LoadOption.OverwriteChanges);
                connection.Close();
                return tb;
            }
            catch 
            {
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SantoshClassMetro
{
    public class DataBase
    {

        string cs;
       SqlConnection conn;
            SqlCommand cmd;
            SqlDataAdapter sda;
         public DataBase()
            {
                DbAccess db = new DbAccess();
                cs = db.cs;
             conn = new SqlConnection(cs);
             cmd = new SqlCommand();
              sda = new SqlDataAdapter();
         }

        public  DataTable getDataSet(string Query)
        {
            DataTable dt = new DataTable();
    
            try
            {
                
                conn.Open();
                cmd.CommandText = Query;
                cmd.Connection = conn;
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);  conn.Close();
                return dt;
            }
            catch (SqlException)
            {
                return dt;
            }
            finally
            {

            }
           
        }
        public  object getData(string query)
        { 
            object ob=null;
            
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                ob = cmd.ExecuteScalar(); conn.Close();
                return ob;
           
          
               
                  
        }
        public  int noReturn(string query)
        {
            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
              
                return   cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
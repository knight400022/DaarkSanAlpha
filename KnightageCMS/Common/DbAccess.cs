using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;


namespace SantoshClassMetro
{
    public class DbAccess
    {

        public string cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=KnightageCMS;User ID=admin;Password=@bhi1234";
        SqlConnection sqlCon;
        SqlCommand sqlCmd;

        public string getCon() {
            return  cs;
        }
        public DbAccess()
        {
            DirectoryInfo di = new DirectoryInfo(System.IO.Directory.GetCurrentDirectory());
            sqlCon = new SqlConnection(cs);
            sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Connection = sqlCon;
        }




        /// <summary>
        /// METHOD TO GET THE RESULT SET
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="procParam"></param>
        /// <returns></returns>
        public DataSet GetResultSet(string procedureName, Dictionary<string, object> procParam)
        {
            DataSet ds = new DataSet();
            sqlCmd.Parameters.Clear();
            try
            {
                
                sqlCmd.CommandText = procedureName;
                foreach (string keys in procParam.Keys)
                {
                    sqlCmd.Parameters.AddWithValue(keys, procParam[keys]);
                }
                SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
                sda.Fill(ds);
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
            }
            return ds;

        }




        /// <summary>
        /// METHOD TO EXECUTE A DML
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="procParam"></param>
        /// <returns></returns>
        public string ExecuteDml(string procedureName,Dictionary<string,object> procParam)
        {
            string resultVar;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = procedureName;
            sqlCmd.Parameters.Clear();
            foreach (string keys in procParam.Keys)
            {
                sqlCmd.Parameters.AddWithValue(keys, procParam[keys]);
            }

            try
            {
                sqlCon.Open();
                int count=sqlCmd.ExecuteNonQuery();
                if (count > 0)
                {
                    resultVar = "success";
                }
                else {
                    resultVar = "fail";
                }
                sqlCon.Close();
                return resultVar;

            }
            catch (SqlException sqlEx)
            {
                resultVar = sqlEx.Message;
                return resultVar;
            }
            finally
            {
                sqlCon.Close();
                
            }
        }






        public object GetData(string procedureName, Dictionary<string, object> procParam)
        {
            object resultVar;
            sqlCmd.Parameters.Clear();
            sqlCmd.CommandText = procedureName;
            foreach (string keys in procParam.Keys)
            {
                sqlCmd.Parameters.AddWithValue(keys, procParam[keys]);
            }
            
            try
            {
                sqlCon.Open();
                resultVar = sqlCmd.ExecuteScalar();
                
                sqlCon.Close();
                return resultVar;

            }
            catch (SqlException sqlEx)
            {
                resultVar = sqlEx.Message;
                return resultVar;
            }
            finally
            {
                sqlCon.Close();

            }
 
        }
    }
}

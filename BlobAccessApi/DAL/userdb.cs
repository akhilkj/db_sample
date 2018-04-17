using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BlobAccessApi.Models;



namespace BlobAccessApi.DAL
{
    public class userdb
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        public void Addusers(User cs)
        {
            SqlCommand com = new SqlCommand("AddnewUser", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@username",cs.username);
            com.Parameters.AddWithValue("@emailid",cs.emailid);
            com.Parameters.AddWithValue("@photo", cs.photo);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public DataSet GetDetailsbyUsername(string uname)
        {
            SqlCommand com = new SqlCommand("GetbyUname", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@uname", uname);
            SqlDataAdapter data = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds;
        }
    }
}
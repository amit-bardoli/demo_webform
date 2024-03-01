using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace Demo_ASPFrom.Model
{
    public class Registration
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public string name { get; set; }
        public string password { get; set; }
        public int cityId { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string document { get; set; }
        public string status { get; set; }
        public decimal salary { get; set; }
        public DateTime birthdate { get; set; }



        public DataSet Load_RegList()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pr_GetReg_DemoList", con);
                cmd.CommandType = CommandType.StoredProcedure;              
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet Load_CityList()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pr_GetCityList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Save(string name, string password, int cityId, string gender, string email, string document, int status,decimal salary, DateTime birthdate)
        {
            int result = 0;

            con.Open();
            SqlCommand cmd = new SqlCommand("pr_SaveRegistrationData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@City", cityId);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Image", document);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@Salary", salary);
            cmd.Parameters.AddWithValue("@Birthdate", birthdate);

            result = cmd.ExecuteNonQuery();
            con.Close();

            return result;
        }

        public int Update(int id,string name, string password, int cityId, string gender, string email, string document, int status, decimal salary, DateTime birthdate)
        {
            int result = 0;

            con.Open();
            SqlCommand cmd = new SqlCommand("pr_UpdateRegistrationData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@City", cityId);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Image", document);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@Salary", salary);
            cmd.Parameters.AddWithValue("@Birthdate", birthdate);

            result = cmd.ExecuteNonQuery();
            con.Close();

            return result;
        }

        public string Delete(int Id)
        {
            string result = "";

            con.Open();
            SqlCommand cmd = new SqlCommand("pr_DeleteRegistrationData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);

            SqlParameter param = cmd.Parameters.Add("@Image", SqlDbType.VarChar, 200);
            param.Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            con.Close();
            result = cmd.Parameters["@Image"].Value.ToString();
            //File.Delete(Server.MapPath("data" + "\\" + FF));

            return result;
        }

        public DataSet GetById(int id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pr_GetRegistrationData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
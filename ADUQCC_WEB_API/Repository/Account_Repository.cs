//using ADUQCC_WEB_API.Comman_Files;
using ADUQCC_WEB_API.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADUQCC_WEB_API.Repository
{
    public class Account_Repository
    {
        private SqlConnection con;
        //Common C = new Common();
        private SqlCommand com;
        //DataSet dsreq = new DataSet();
        private void Connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["ADUQCC_WEB_API"].ToString();
            con = new SqlConnection(constr);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }



        //public DataTable API_REQUEST_AND_RESPONSE_DETAILS(string ServiceName, string RequestMethod, string RequestContentType,
        //    string RequestUri, string Request_content, DateTime? RequestTimestamp,
        //    DateTime? ResponseTimestamp, string Response_content, string ResponseStatusCode,
        //    string ResponseContentType)
        //{
        //    Connection();
        //    Common C = new Common();
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        com = new SqlCommand("USP_ALB_API_REQUEST_AND_RESPONSE_DETAILS");
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@servic_name", ServiceName);
        //        com.Parameters.AddWithValue("@request_method", RequestMethod);
        //        com.Parameters.AddWithValue("@request_content_type", RequestContentType);
        //        com.Parameters.AddWithValue("@request_uri", RequestUri);
        //        com.Parameters.AddWithValue("@request_content", Request_content);
        //        com.Parameters.AddWithValue("@request_timestamp", RequestTimestamp);
        //        com.Parameters.AddWithValue("@responseTimestamp", ResponseTimestamp);
        //        com.Parameters.AddWithValue("@response_content", Response_content);
        //        com.Parameters.AddWithValue("@response_status_code", ResponseStatusCode);
        //        com.Parameters.AddWithValue("@response_content_type", ResponseContentType);
        //        con.Open();
        //        com.Connection = con;
        //        SqlDataAdapter da = new SqlDataAdapter(com);
        //        da.Fill(dt);
        //        com.Parameters.Clear();
        //        con.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        C.writeData(ex.Message.ToString(), "Respository_GET_APPLICATION_EXCEPTION");
        //        return dt;
        //    }

        //}

        //public DataTable GET_APPLICATION_EXCEPTION(string Application_Name, string Errror_Model_Name, string Errror_function, string AppVersion, string Error_line, string Error_from, string Error_discription, string Application_Identity, string User_ID)
        //{
        //    Connection();
        //    Common C = new Common();
        //    DataTable dt = new DataTable();
        //    try
        //    {

        //        com = new SqlCommand("USP_GET_APPLICATION_EXCEPTION");
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@Application_Name", Application_Name);
        //        com.Parameters.AddWithValue("@Errror_Model_Name", Errror_Model_Name);
        //        com.Parameters.AddWithValue("@Errror_function", Errror_function);
        //        com.Parameters.AddWithValue("@Version", AppVersion);
        //        com.Parameters.AddWithValue("@Error_line", Error_line);
        //        com.Parameters.AddWithValue("@Error_from", Error_from);
        //        com.Parameters.AddWithValue("@Error_discription", Error_discription);
        //        com.Parameters.AddWithValue("@Application_Identity", Application_Identity);
        //        com.Parameters.AddWithValue("@User_ID", User_ID);
        //        con.Open();
        //        com.Connection = con;
        //        SqlDataAdapter da = new SqlDataAdapter(com);
        //        da.Fill(dt);
        //        com.Parameters.Clear();
        //        con.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        C.writeData(ex.Message.ToString(), "Respository_GET_APPLICATION_EXCEPTION");
        //        return dt;
        //    }

        //}

        //public DataTable LOGIN(string Login_User, string Password, string Lang_Id,string Designation_Id, string Login_Mode, string latitude, string longitude, string IMEI, string Firebase_ID, string Android_IOS_Web)
        //{
        //    Connection();
        //    Common C = new Common();
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        com = new SqlCommand("USP_EMPLOYEE_LOGIN")
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };
        //        com.Parameters.AddWithValue("@UserName", Login_User);
        //        com.Parameters.AddWithValue("@Password", Password);
        //        com.Parameters.AddWithValue("@Lang_Id", Lang_Id);
        //        com.Parameters.AddWithValue("@DESIGNATION", Designation_Id);
        //        com.Parameters.AddWithValue("@Login_Mode", Login_Mode);
        //        com.Parameters.AddWithValue("@latitude", latitude);
        //        com.Parameters.AddWithValue("@longitude", longitude);
        //        com.Parameters.AddWithValue("@IMEI", IMEI);
        //        com.Parameters.AddWithValue("@Firebase_ID", Firebase_ID);
        //        com.Parameters.AddWithValue("@Android_IOS_Web", Android_IOS_Web);
        //        con.Open();
        //        com.Connection = con;
        //        SqlDataAdapter da = new SqlDataAdapter(com);
        //        da.Fill(dt);
        //        com.Parameters.Clear();
        //        con.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        C.writeData(ex.Message.ToString(), "Respository_USP_VOILA_LOGIN");
        //        return dt;
        //    }
        //}

        public GET_USER_DETAILS GetLoginDetails(string Username, string Password, string Desi_Id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Login_User", Username);
                param.Add("@Password", Password);
                param.Add("@Designation_Id", Desi_Id);
                Connection();
                con.Open();
                var query = "[USP_EMPLOYEE_LOGIN]";
                var objUserList = SqlMapper.Query<GET_USER_DETAILS>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
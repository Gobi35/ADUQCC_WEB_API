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
    public class Employee_Repository
    {
        public SqlConnection con;
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["ADUQCC_WEB_API"].ToString();
            con = new SqlConnection(constr);
        }

        public IEnumerable<GET_EMPLOYEE_DETAILS> GetEmployeeDetails()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_EMPLOYEE_DETAILS]";
                IEnumerable<GET_EMPLOYEE_DETAILS> objUserList = SqlMapper.Query<GET_EMPLOYEE_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public RETURN_MESSAGE DeleteEmployeeDetails(string EMP_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@EMP_ID", EMP_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_EMPLOYEE_DETAILS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_EMPLOYEE_DETAILS EditEmployeeDetails(string EMP_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@EMP_ID", EMP_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_EMPLOYEE_DETAILS]";
                var objUserList = SqlMapper.Query<ADD_EMPLOYEE_DETAILS>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_EMPLOYEE_DETAILS AddEmployeeDetails(ADD_EMPLOYEE_DETAILS _EMPLOYEE_DETAILS)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@EMP_ID", _EMPLOYEE_DETAILS.EMP_ID);
                param.Add("@EMP_FIRSTNAME", _EMPLOYEE_DETAILS.EMP_FIRSTNAME);
                param.Add("@EMP_LASTNAME", _EMPLOYEE_DETAILS.EMP_LASTNAME);
                param.Add("@EMP_GENDER", _EMPLOYEE_DETAILS.EMP_GENDER);
                param.Add("@EMP_NATIONALITY_ID", _EMPLOYEE_DETAILS.EMP_NATIONALITY_ID);
                param.Add("@EMP_DESIGNATION_ID", _EMPLOYEE_DETAILS.EMP_DESIGNATION_ID);
                param.Add("@EMP_LOCATION_ID", _EMPLOYEE_DETAILS.EMP_LOCATION_ID);
                param.Add("@EMP_BUILDING_ID", _EMPLOYEE_DETAILS.EMP_BUILDING_ID);
                param.Add("@EMP_SECTOR_ID", _EMPLOYEE_DETAILS.EMP_SECTOR_ID);
                param.Add("@EMP_DEPARTMENT_ID", _EMPLOYEE_DETAILS.EMP_DEPARTMENT_ID);
                param.Add("@EMP_SECTION_ID", _EMPLOYEE_DETAILS.EMP_SECTION_ID);
                param.Add("@EMP_EMAIL", _EMPLOYEE_DETAILS.EMP_EMAIL);
                param.Add("@EMP_PHONE_NO", _EMPLOYEE_DETAILS.EMP_PHONE_NO);
                param.Add("@EMP_TEL_NO", _EMPLOYEE_DETAILS.EMP_TEL_NO);
                param.Add("@EMP_PASSWORD", _EMPLOYEE_DETAILS.EMP_PASSWORD);
                param.Add("@EMP_STATUS", _EMPLOYEE_DETAILS.EMP_STATUS);
                param.Add("@EMP_USERNAME", _EMPLOYEE_DETAILS.EMP_USERNAME);
                param.Add("@EMP_NAME_AR", _EMPLOYEE_DETAILS.EMP_NAME_AR);
                connection();
                con.Open();
                var query = "[USP_ADD_EMPLOYEE_DETAILS]";
                var objUserList = SqlMapper.Query<ADD_EMPLOYEE_DETAILS>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE AddHealthVitalsDetails(HEALTH_VITAL _HEALTH_VITAL)
        {
            try
            {
                foreach (var item in _HEALTH_VITAL.HEALTH_VITAL_LIST)
                {
                    connection();
                    con.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@EMP_ID", item.EMP_ID);
                    var query = "[USP_DELETE_HEALTH_VITALS]";
                    var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                    con.Close();
                }
                connection();
                con.Open();
                con.Execute("USP_ADD_HEALTH_VITALS", _HEALTH_VITAL.HEALTH_VITAL_LIST, commandType: CommandType.StoredProcedure);
                con.Close();
                RETURN_MESSAGE rETURN_MESSAGE = new RETURN_MESSAGE
                {
                    STATUS_CODE = "200",
                    MESSAGE = "Health Added Successful"
                };
                return rETURN_MESSAGE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<HEALTH_VITAL_LIST> GetHealthVitalsDetails(string EMP_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@EMP_ID", EMP_ID);
                connection();
                con.Open();
                var query = "[USP_GET_HEALTH_VITALS]";
                IEnumerable<HEALTH_VITAL_LIST> objUserList = SqlMapper.Query<HEALTH_VITAL_LIST>(con, query, param, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE GetActiveDeactiveStatus(string EMP_ID, string STATUS,string PASSWORD, string USERNAME)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@EMP_ID", EMP_ID);
                param.Add("@STATUS", STATUS);
                param.Add("@PASSWORD", PASSWORD);
                param.Add("@USERNAME", USERNAME);
                connection();
                con.Open();
                var query = "[USP_UPDATE_ACTIVE_DEACTIVE]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
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
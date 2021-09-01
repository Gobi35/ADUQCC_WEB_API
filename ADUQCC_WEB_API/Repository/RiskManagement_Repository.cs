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
    public class RiskManagement_Repository
    {
        public SqlConnection con;
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["ADUQCC_WEB_API"].ToString();
            con = new SqlConnection(constr);
        }

        #region [Risk Category Master]
        public IEnumerable<GET_RM_RISK_CAT_MASTER> GETRMRISKCATMAS()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_RM_GET_RISK_CAT_MAS]";
                IEnumerable<GET_RM_RISK_CAT_MASTER> objUserList = SqlMapper.Query<GET_RM_RISK_CAT_MASTER>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE ADDRMRISKCATMAS(ADD_RM_RISK_CAT_MASTER _ADDRMRISKCATMASTER)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RISK_CAT_MAS_ID", _ADDRMRISKCATMASTER.RISK_CAT_MAS_ID);
                param.Add("@RISK_CAT_MAS_NAME", _ADDRMRISKCATMASTER.RISK_CAT_MAS_NAME);
                param.Add("@RISK_CAT_MAS_NAME_AR", _ADDRMRISKCATMASTER.RISK_CAT_MAS_NAME_AR);
                param.Add("@STATUS", _ADDRMRISKCATMASTER.STATUS);
                connection();
                con.Open();
                var query = "[USP_RM_ADD_RISK_CAT_MAS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_RM_RISK_CAT_MASTER GETEDITRMRISKCATMAS(string RISK_CAT_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RISK_CAT_MAS_ID", RISK_CAT_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_EDIT_RISK_CAT_MAS]";
                var objUserList = SqlMapper.Query<ADD_RM_RISK_CAT_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DELETERMRISKCATMAS(string RISK_CAT_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RISK_CAT_MAS_ID", RISK_CAT_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_DELETE_RISK_CAT_MAS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion

        #region [Hazard Master]
        public IEnumerable<GET_RM_HAZARD_MASTER> GETRMHAZARDMASREPO()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_RM_GET_HAZARD_MAS]";
                IEnumerable<GET_RM_HAZARD_MASTER> objUserList = SqlMapper.Query<GET_RM_HAZARD_MASTER>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE ADDRMHAZARDMASREPO(ADD_RM_HAZARD_MASTER _ADDRMHAZARDMASTER)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@HAZARD_MAS_ID", _ADDRMHAZARDMASTER.HAZARD_MAS_ID);
                param.Add("@HAZ_RISK_CAT_MAS_ID", _ADDRMHAZARDMASTER.HAZ_RISK_CAT_MAS_ID);
                param.Add("@HAZARD_MAS_NAME", _ADDRMHAZARDMASTER.HAZARD_MAS_NAME);
                param.Add("@HAZARD_MAS_NAME_AR", _ADDRMHAZARDMASTER.HAZARD_MAS_NAME_AR);
                param.Add("@STATUS", _ADDRMHAZARDMASTER.STATUS);
                connection();
                con.Open();
                var query = "[USP_RM_ADD_HAZARD_MAS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_RM_HAZARD_MASTER GETEDITRMHAZARDMASREPO(string HAZARD_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@HAZARD_MAS_ID", HAZARD_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_EDIT_HAZARD_MAS]";
                var objUserList = SqlMapper.Query<ADD_RM_HAZARD_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DELETERMHAZARDMASREPO(string HAZARD_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@HAZARD_MAS_ID", HAZARD_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_DELETE_HAZARD_MAS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion

        #region [Risks and Other Risks]

        public IEnumerable<GET_RM_HAZARD_MASTER>  GETHAZARDSELECTREPO(string HAZ_RISK_CAT_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@HAZ_RISK_CAT_MAS_ID", HAZ_RISK_CAT_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_GET_HAZARD_SELECT]";
                IEnumerable<GET_RM_HAZARD_MASTER> objUserList = SqlMapper.Query<GET_RM_HAZARD_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<GET_RM_RISKS_OTHER_RISKS> GETRMRISKOTHERRISKREPO()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_RM_GET_RISKS_OTHER_RISKS]";
                IEnumerable<GET_RM_RISKS_OTHER_RISKS> objUserList = SqlMapper.Query<GET_RM_RISKS_OTHER_RISKS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE ADDRMRISKOTHERRISKREPO(ADD_RM_RISKS_OTHER_RISKS _ADDRMRISKOTHERRISK)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RISKS_OTHER_RISKS_ID", _ADDRMRISKOTHERRISK.RISKS_OTHER_RISKS_ID);
                param.Add("@RISK_CAT_MAS_ID", _ADDRMRISKOTHERRISK.RISK_CAT_MAS_ID);
                param.Add("@RISKS_HAZARD_MAS_ID", _ADDRMRISKOTHERRISK.RISKS_HAZARD_MAS_ID);
                param.Add("@RISKS_OTHER_RISKS_NAME", _ADDRMRISKOTHERRISK.RISKS_OTHER_RISKS_NAME);
                param.Add("@RISKS_OTHER_RISKS_NAME_AR", _ADDRMRISKOTHERRISK.RISKS_OTHER_RISKS_NAME_AR);
                param.Add("@STATUS", _ADDRMRISKOTHERRISK.STATUS);
                connection();
                con.Open();
                var query = "[USP_RM_ADD_RISKS_OTHER_RISKS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_RM_RISKS_OTHER_RISKS GETEDITRMRISKOTHERRISKREPO(string RISKS_OTHER_RISKS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RISKS_OTHER_RISKS_ID", RISKS_OTHER_RISKS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_EDIT_RISKS_OTHER_RISKS]";
                var objUserList = SqlMapper.Query<ADD_RM_RISKS_OTHER_RISKS>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DELETERMRISKOTHERRISKREPO(string RISKS_OTHER_RISKS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RISKS_OTHER_RISKS_ID", RISKS_OTHER_RISKS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_DELETE_RISKS_OTHER_RISKS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion

        #region [Persons/Groups Exposed]
        public IEnumerable<GET_RM_PERSONS_GROUPS> GETRMPERSONSGROUPSREPO()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_RM_GET_PERSONS_GROUPS]";
                IEnumerable<GET_RM_PERSONS_GROUPS> objUserList = SqlMapper.Query<GET_RM_PERSONS_GROUPS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE ADDRMPERSONSGROUPSREPO(ADD_RM_PERSONS_GROUPS _ADDRMPERSONSGROUPS)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@PERSON_GROUP_ID", _ADDRMPERSONSGROUPS.PERSON_GROUP_ID);
                param.Add("@RISK_CAT_MAS_ID", _ADDRMPERSONSGROUPS.RISK_CAT_MAS_ID);
                param.Add("@PG_HAZARD_MAS_ID", _ADDRMPERSONSGROUPS.PG_HAZARD_MAS_ID);
                param.Add("@PERSON_GROUP_NAME", _ADDRMPERSONSGROUPS.PERSON_GROUP_NAME);
                param.Add("@PERSON_GROUP_NAME_AR", _ADDRMPERSONSGROUPS.PERSON_GROUP_NAME_AR);
                param.Add("@STATUS", _ADDRMPERSONSGROUPS.STATUS);
                connection();
                con.Open();
                var query = "[USP_RM_ADD_PERSONS_GROUPS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_RM_PERSONS_GROUPS GETEDITRMPERSONSGROUPSREPO(string PERSON_GROUP_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@PERSON_GROUP_ID", PERSON_GROUP_ID);
                connection();
                con.Open();
                var query = "[USP_RM_EDIT_PERSONS_GROUPS]";
                var objUserList = SqlMapper.Query<ADD_RM_PERSONS_GROUPS>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DELETERMPERSONSGROUPSREPO(string PERSON_GROUP_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@PERSON_GROUP_ID", PERSON_GROUP_ID);
                connection();
                con.Open();
                var query = "[USP_RM_DELETE_PERSONS_GROUPS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion

        #region [Details of any Existing Controls]
        public IEnumerable<GET_RM_DETAILS_EXIST_CONT> GETDECREPO()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_RM_GET_DETAILS_EXIST_CONT]";
                IEnumerable<GET_RM_DETAILS_EXIST_CONT> objUserList = SqlMapper.Query<GET_RM_DETAILS_EXIST_CONT>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE ADDDECREPO(ADD_RM_DETAILS_EXIST_CONT _ADDDEC)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@DETAILS_EXIST_CONT_ID", _ADDDEC.DETAILS_EXIST_CONT_ID);
                param.Add("@RISK_CAT_MAS_ID", _ADDDEC.RISK_CAT_MAS_ID);
                param.Add("@DEC_HAZARD_MAS_ID", _ADDDEC.DEC_HAZARD_MAS_ID);
                param.Add("@DETAILS_EXIST_CONT_NAME", _ADDDEC.DETAILS_EXIST_CONT_NAME);
                param.Add("@DETAILS_EXIST_CONT_NAME_AR", _ADDDEC.DETAILS_EXIST_CONT_NAME_AR);
                param.Add("@STATUS", _ADDDEC.STATUS);
                connection();
                con.Open();
                var query = "[USP_RM_ADD_DETAILS_EXIST_CONT]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_RM_DETAILS_EXIST_CONT GETEDITDECREPO(string DETAILS_EXIST_CONT_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@DETAILS_EXIST_CONT_ID", DETAILS_EXIST_CONT_ID);
                connection();
                con.Open();
                var query = "[USP_RM_EDIT_DETAILS_EXIST_CONT]";
                var objUserList = SqlMapper.Query<ADD_RM_DETAILS_EXIST_CONT>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DELETEDECREPO(string DETAILS_EXIST_CONT_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@DETAILS_EXIST_CONT_ID", DETAILS_EXIST_CONT_ID);
                connection();
                con.Open();
                var query = "[USP_RM_DELETE_DETAILS_EXIST_CONT]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion

        #region [Additional Control Measures]
        public IEnumerable<GET_RM_ADD_CONT_MEAS> GETADDTCONTMEASREPO()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_RM_GET_ADDT_CONT_MEAS]";
                IEnumerable<GET_RM_ADD_CONT_MEAS> objUserList = SqlMapper.Query<GET_RM_ADD_CONT_MEAS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE ADDCONTMEASREPO(ADD_RM_ADD_CONT_MEAS _ADDCONTMEAS)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ADD_CONT_MEAS_ID", _ADDCONTMEAS.ADD_CONT_MEAS_ID);
                param.Add("@RISK_CAT_MAS_ID", _ADDCONTMEAS.RISK_CAT_MAS_ID);
                param.Add("@ACM_HAZARD_MAS_ID", _ADDCONTMEAS.ACM_HAZARD_MAS_ID);
                param.Add("@ADD_CONT_MEAS_NAME", _ADDCONTMEAS.ADD_CONT_MEAS_NAME);
                param.Add("@ADD_CONT_MEAS_NAME_AR", _ADDCONTMEAS.ADD_CONT_MEAS_NAME_AR);
                param.Add("@STATUS", _ADDCONTMEAS.STATUS);
                connection();
                con.Open();
                var query = "[USP_RM_ADD_ADDT_CONT_MEAS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_RM_ADD_CONT_MEAS GETEDITADDCONTMEASREPO(string ADD_CONT_MEAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ADD_CONT_MEAS_ID", ADD_CONT_MEAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_EDIT_ADDT_CONT_MEAS]";
                var objUserList = SqlMapper.Query<ADD_RM_ADD_CONT_MEAS>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DELETEADDCONTMEASREPO(string ADD_CONT_MEAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ADD_CONT_MEAS_ID", ADD_CONT_MEAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_DELETE_ADDT_CONT_MEAS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion

        #region [Opportunities and other opportunities]
        public IEnumerable<GET_RM_OPPORTUNITIES> GETOPPORTUNITIESREPO()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_RM_GET_OPPORTUNITIES]";
                IEnumerable<GET_RM_OPPORTUNITIES> objUserList = SqlMapper.Query<GET_RM_OPPORTUNITIES>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE ADDOPPORTUNITIESREPO(ADD_RM_OPPORTUNITIES _ADDOPPORTUNITIES)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@OPPORTUNITIES_ID", _ADDOPPORTUNITIES.OPPORTUNITIES_ID);
                param.Add("@RISK_CAT_MAS_ID", _ADDOPPORTUNITIES.RISK_CAT_MAS_ID);
                param.Add("@OPTY_HAZARD_MAS_ID", _ADDOPPORTUNITIES.OPTY_HAZARD_MAS_ID);
                param.Add("@OPPORTUNITIES_NAME", _ADDOPPORTUNITIES.OPPORTUNITIES_NAME);
                param.Add("@OPPORTUNITIES_NAME_AR", _ADDOPPORTUNITIES.OPPORTUNITIES_NAME_AR);
                param.Add("@STATUS", _ADDOPPORTUNITIES.STATUS);
                connection();
                con.Open();
                var query = "[USP_RM_ADD_OPPORTUNITIES]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_RM_OPPORTUNITIES GETEDITOPPORTUNITIESREPO(string OPPORTUNITIES_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@OPPORTUNITIES_ID", OPPORTUNITIES_ID);
                connection();
                con.Open();
                var query = "[USP_RM_EDIT_OPPORTUNITIES]";
                var objUserList = SqlMapper.Query<ADD_RM_OPPORTUNITIES>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DELETEOPPORTUNITIESREPO(string OPPORTUNITIES_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@OPPORTUNITIES_ID", OPPORTUNITIES_ID);
                connection();
                con.Open();
                var query = "[USP_RM_DELETE_OPPORTUNITIES]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion

        #region [Critical Hazard Master]
        public IEnumerable<GET_RM_CRIT_HAZARD_MASTER> GETRMCRITHAZARDMASREPO()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_RM_GET_CRIT_HAZARD_MAS]";
                IEnumerable<GET_RM_CRIT_HAZARD_MASTER> objUserList = SqlMapper.Query<GET_RM_CRIT_HAZARD_MASTER>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE ADDRMCRITHAZARDMASREPO(ADD_RM_CRIT_HAZARD_MASTER _ADDRMCRITHAZARDMASTER)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@CRIT_HAZARD_MAS_ID", _ADDRMCRITHAZARDMASTER.CRIT_HAZARD_MAS_ID);
                param.Add("@CRIT_HAZARD_MAS_NAME", _ADDRMCRITHAZARDMASTER.CRIT_HAZARD_MAS_NAME);
                param.Add("@CRIT_HAZARD_MAS_NAME_AR", _ADDRMCRITHAZARDMASTER.CRIT_HAZARD_MAS_NAME_AR);
                param.Add("@STATUS", _ADDRMCRITHAZARDMASTER.STATUS);
                connection();
                con.Open();
                var query = "[USP_RM_ADD_CRIT_HAZARD_MAS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_RM_CRIT_HAZARD_MASTER GETEDITRMCRITHAZARDMASREPO(string CRIT_HAZARD_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@CRIT_HAZARD_MAS_ID", CRIT_HAZARD_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_EDIT_CRIT_HAZARD_MAS]";
                var objUserList = SqlMapper.Query<ADD_RM_CRIT_HAZARD_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DELETERMCRITHAZARDMASREPO(string CRIT_HAZARD_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@CRIT_HAZARD_MAS_ID", CRIT_HAZARD_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_DELETE_CRIT_HAZARD_MAS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion

        #region [Non Critical Hazard Master]
        public IEnumerable<GET_RM_NON_CRIT_HAZ_MASTER> GETRMNONCRITHAZMASREPO()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_RM_GET_NON_CRIT_HAZ_MAS]";
                IEnumerable<GET_RM_NON_CRIT_HAZ_MASTER> objUserList = SqlMapper.Query<GET_RM_NON_CRIT_HAZ_MASTER>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE ADDRMNONCRITHAZMASREPO(ADD_RM_NON_CRIT_HAZ_MASTER _ADDADDRMNONCRITHAZMASTER)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@NON_CRIT_HAZ_MAS_ID", _ADDADDRMNONCRITHAZMASTER.NON_CRIT_HAZ_MAS_ID);
                param.Add("@NON_CRIT_HAZ_MAS_NAME", _ADDADDRMNONCRITHAZMASTER.NON_CRIT_HAZ_MAS_NAME);
                param.Add("@NON_CRIT_HAZ_MAS_NAME_AR", _ADDADDRMNONCRITHAZMASTER.NON_CRIT_HAZ_MAS_NAME_AR);
                param.Add("@STATUS", _ADDADDRMNONCRITHAZMASTER.STATUS);
                connection();
                con.Open();
                var query = "[USP_RM_ADD_NON_CRIT_HAZ_MAS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_RM_NON_CRIT_HAZ_MASTER GETEDITRMNONCRITHAZMASREPO(string NON_CRIT_HAZ_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@NON_CRIT_HAZ_MAS_ID", NON_CRIT_HAZ_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_EDIT_NON_CRIT_HAZ_MAS]";
                var objUserList = SqlMapper.Query<ADD_RM_NON_CRIT_HAZ_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DELETERMNONCRITHAZMASREPO(string NON_CRIT_HAZ_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@NON_CRIT_HAZ_MAS_ID", NON_CRIT_HAZ_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_DELETE_NON_CRIT_HAZ_MAS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion

        #region [Non-Routine and Emergencies]
        public IEnumerable<GET_RM_NON_ROUT_EMERG_MASTER> GETRMNONROUTEMERGMASREPO()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_RM_GET_NON_ROUT_EMERG_MAS]";
                IEnumerable<GET_RM_NON_ROUT_EMERG_MASTER> objUserList = SqlMapper.Query<GET_RM_NON_ROUT_EMERG_MASTER>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE ADDRMNONROUTEMERGMASREPO(ADD_RM_NON_ROUT_EMERG_MASTER _ADDRMNONROUTEMERGMASTER)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@NON_ROUT_EMERG_ID", _ADDRMNONROUTEMERGMASTER.NON_ROUT_EMERG_ID);
                param.Add("@NON_ROUT_EMERG_NAME", _ADDRMNONROUTEMERGMASTER.NON_ROUT_EMERG_NAME);
                param.Add("@NON_ROUT_EMERG_NAME_AR", _ADDRMNONROUTEMERGMASTER.NON_ROUT_EMERG_NAME_AR);
                param.Add("@STATUS", _ADDRMNONROUTEMERGMASTER.STATUS);
                connection();
                con.Open();
                var query = "[USP_RM_ADD_NON_ROUT_EMERG_MAS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_RM_NON_ROUT_EMERG_MASTER GETEDITRMNONROUTEMERGMASREPO(string NON_ROUT_EMERG_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@NON_ROUT_EMERG_ID", NON_ROUT_EMERG_ID);
                connection();
                con.Open();
                var query = "[USP_RM_EDIT_NON_ROUT_EMERG_MAS]";
                var objUserList = SqlMapper.Query<ADD_RM_NON_ROUT_EMERG_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DELETERMNONROUTEMERGMASREPO(string NON_ROUT_EMERG_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@NON_ROUT_EMERG_ID", NON_ROUT_EMERG_ID);
                connection();
                con.Open();
                var query = "[USP_RM_DELETE_NON_ROUT_EMERG_MAS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion

        #region [Existing control measures for identified hazard]
        public IEnumerable<GET_RM_EXISTING_CMIH_MASTER> GETRMEXISTINGCMIHMASREPO()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_RM_GET_EXISTING_CMIH_MAS]";
                IEnumerable<GET_RM_EXISTING_CMIH_MASTER> objUserList = SqlMapper.Query<GET_RM_EXISTING_CMIH_MASTER>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE ADDRMEXISTINGCMIHMASREPO(ADD_RM_EXISTING_CMIH_MASTER _ADDRMEXISTINGCMIHMASTER)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@EXISTING_CMIH_MAS_ID", _ADDRMEXISTINGCMIHMASTER.EXISTING_CMIH_MAS_ID);
                param.Add("@EXISTING_CMIH_MAS_NAME", _ADDRMEXISTINGCMIHMASTER.EXISTING_CMIH_MAS_NAME);
                param.Add("@EXISTING_CMIH_MAS_NAME_AR", _ADDRMEXISTINGCMIHMASTER.EXISTING_CMIH_MAS_NAME_AR);
                param.Add("@STATUS", _ADDRMEXISTINGCMIHMASTER.STATUS);
                connection();
                con.Open();
                var query = "[USP_RM_ADD_EXISTING_CMIH_MAS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_RM_EXISTING_CMIH_MASTER GETEDITRMEXISTINGCMIHMASREPO(string EXISTING_CMIH_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@EXISTING_CMIH_MAS_ID", EXISTING_CMIH_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_EDIT_EXISTING_CMIH_MAS]";
                var objUserList = SqlMapper.Query<ADD_RM_EXISTING_CMIH_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DELETERMEXISTINGCMIHMASREPO(string EXISTING_CMIH_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@EXISTING_CMIH_MAS_ID", EXISTING_CMIH_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_DELETE_EXISTING_CMIH_MAS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion


        #region [ Risk Assessment Dropdown Select]
        public IEnumerable<GET_RM_HAZARD_MASTER> GetHazardDescSelectRepo(string HAZ_RISK_CAT_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@HAZ_RISK_CAT_MAS_ID", HAZ_RISK_CAT_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_GET_HAZARD_SELECT]";
                IEnumerable<GET_RM_HAZARD_MASTER> objUserList = SqlMapper.Query<GET_RM_HAZARD_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<GET_RM_RISKS_OTHER_RISKS> GetRisksOtherRisksSelectRepo(string RISKS_HAZARD_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RISKS_HAZARD_MAS_ID", RISKS_HAZARD_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_GET_RISKS_OTHER_RISKS_SELECT]";
                IEnumerable<GET_RM_RISKS_OTHER_RISKS> objUserList = SqlMapper.Query<GET_RM_RISKS_OTHER_RISKS>(con, query, param, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<GET_RM_PERSONS_GROUPS> GetPersonsGroupsSelectRepo(string PG_HAZARD_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@PG_HAZARD_MAS_ID", PG_HAZARD_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_GET_PERSONS_GROUPS_SELECT]";
                IEnumerable<GET_RM_PERSONS_GROUPS> objUserList = SqlMapper.Query<GET_RM_PERSONS_GROUPS>(con, query, param, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<GET_RM_DETAILS_EXIST_CONT> GetDetailsExistingControlsSelectRepo(string DEC_HAZARD_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@DEC_HAZARD_MAS_ID", DEC_HAZARD_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_GET_DETAILS_EXIST_CONT_SELECT]";
                IEnumerable<GET_RM_DETAILS_EXIST_CONT> objUserList = SqlMapper.Query<GET_RM_DETAILS_EXIST_CONT>(con, query, param, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<GET_RM_ADD_CONT_MEAS> GetAddConMeasSelectRepo(string ACM_HAZARD_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ACM_HAZARD_MAS_ID", ACM_HAZARD_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_GET_ADD_CONT_MEAS_SELECT]";
                IEnumerable<GET_RM_ADD_CONT_MEAS> objUserList = SqlMapper.Query<GET_RM_ADD_CONT_MEAS>(con, query, param, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<GET_RM_OPPORTUNITIES> GetOpportunitiesSelectRepo(string OPTY_HAZARD_MAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@OPTY_HAZARD_MAS_ID", OPTY_HAZARD_MAS_ID);
                connection();
                con.Open();
                var query = "[USP_RM_GET_OPPORTUNITIES_SELECT]";
                IEnumerable<GET_RM_OPPORTUNITIES> objUserList = SqlMapper.Query<GET_RM_OPPORTUNITIES>(con, query, param, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


    }
}
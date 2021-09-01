using ADUQCC_WEB_API.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Runtime;
namespace ADUQCC_WEB_API.Repository
{
    public class EmergencyMaster_Repository
    {
        public SqlConnection con;

        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["ADUQCC_WEB_API"].ToString();
            con = new SqlConnection(constr);
        }

        #region [ImmediateCause_UnsafeAct]
        public IEnumerable<GET_EMR_IC_ACT_DETAILS> GetEMRICActDetails()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_EMR_IC_ACT_DETAILS]";
                IEnumerable<GET_EMR_IC_ACT_DETAILS> objUserList = SqlMapper.Query<GET_EMR_IC_ACT_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE AddEMRICActMaster(ADD_EMRICAct_MASTER _EMRICAct_MASTER)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@CAUSE_ID", _EMRICAct_MASTER.CAUSE_ID);
                param.Add("@CAUSENAME", _EMRICAct_MASTER.CAUSENAME);
                param.Add("@CAUSE_NAME_AR", _EMRICAct_MASTER.CAUSE_NAME_AR);
                param.Add("@STATUS", _EMRICAct_MASTER.STATUS);
                connection();
                con.Open();
                var query = "[USP_ADD_EMRICAct_Master]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_EMRICAct_MASTER GetEMRICActEdit(string CAUSE_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@CAUSE_ID", CAUSE_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_EMR_IC_ACT]";
                var objUserList = SqlMapper.Query<ADD_EMRICAct_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteEMRICAct(string CAUSE_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@CAUSE_ID", CAUSE_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_EMRICAct_Master]";
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

        #region [ImmediateCause_UnsafeConditions]
        public IEnumerable<GET_EMR_IC_UC_DETAILS> GetEMRICUCDetails()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_EMR_IC_UC_DETAILS]";
                IEnumerable<GET_EMR_IC_UC_DETAILS> objUserList = SqlMapper.Query<GET_EMR_IC_UC_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE AddEEMRICUC(ADD_EMR_IC_UC_MASTER _ADDEMRICUC)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@IM_UNSAFE_ID", _ADDEMRICUC.IM_UNSAFE_ID);
                param.Add("@IM_UNSAFENAME", _ADDEMRICUC.IM_UNSAFENAME);
                param.Add("@IM_UNSAFE_NAME_AR", _ADDEMRICUC.IM_UNSAFE_NAME_AR);
                param.Add("@STATUS", _ADDEMRICUC.STATUS);
                connection();
                con.Open();
                var query = "[USP_ADD_EMRICUC]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_EMR_IC_UC_MASTER GetEMRICUCEdit(string IM_UNSAFE_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@IM_UNSAFE_ID", IM_UNSAFE_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_EMR_IC_UC]";
                var objUserList = SqlMapper.Query<ADD_EMR_IC_UC_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteEMRICUC(string IM_UNSAFE_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@IM_UNSAFE_ID", IM_UNSAFE_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_EMRICUC_Master]";
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

        #region [Root Causes (Personal factor)]
        public IEnumerable<GET_EMR_RC_PF_DETAILS> GetEMRRCPFDetails()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_EMR_RC_PF_DETAILS]";
                IEnumerable<GET_EMR_RC_PF_DETAILS> objUserList = SqlMapper.Query<GET_EMR_RC_PF_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE AddEEMRRCPF(ADD_EMR_RC_PF_MASTER _AddEEMRRCPF)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ROOT_CAUSE_ID", _AddEEMRRCPF.ROOT_CAUSE_ID);
                param.Add("@ROOT_CAUSE_NAME", _AddEEMRRCPF.ROOT_CAUSE_NAME);
                param.Add("@ROOT_CAUSE_NAME_AR", _AddEEMRRCPF.ROOT_CAUSE_NAME_AR);
                param.Add("@STATUS", _AddEEMRRCPF.STATUS);
                connection();
                con.Open();
                var query = "[USP_ADD_EMRRCPF]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_EMR_RC_PF_MASTER GetEMRRCPFEdit(string ROOT_CAUSE_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ROOT_CAUSE_ID", ROOT_CAUSE_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_EMR_RC_PF]";
                var objUserList = SqlMapper.Query<ADD_EMR_RC_PF_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteEMRRCPF(string ROOT_CAUSE_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ROOT_CAUSE_ID", ROOT_CAUSE_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_EMR_RC_PF]";
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

        #region [Root Causes (System factor)]
        public IEnumerable<GET_EMR_RC_SF_DETAILS> GetEMRRCSFDetails()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_EMR_RC_SF_DETAILS]";
                IEnumerable<GET_EMR_RC_SF_DETAILS> objUserList = SqlMapper.Query<GET_EMR_RC_SF_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE AddEEMRRCSF(ADD_EMR_RC_SF_MASTER _AddEEMRRCSF)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RC_SF_ID", _AddEEMRRCSF.RC_SF_ID);
                param.Add("@RC_SF_NAME", _AddEEMRRCSF.RC_SF_NAME);
                param.Add("@RC_SF_NAME_AR", _AddEEMRRCSF.RC_SF_NAME_AR);
                param.Add("@STATUS", _AddEEMRRCSF.STATUS);
                connection();
                con.Open();
                var query = "[USP_ADD_EMR_RC_SF]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_EMR_RC_SF_MASTER GetEMRRCSFEdit(string RC_SF_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RC_SF_ID", RC_SF_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_EMR_RC_SF]";
                var objUserList = SqlMapper.Query<ADD_EMR_RC_SF_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteEMRRCSF(string RC_SF_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RC_SF_ID", RC_SF_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_EMR_RC_SF]";
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

        #region [Nature of Injury / Illness]
        public IEnumerable<GET_EMR_NATURE_INJURY_DETAILS> GetEMRNIIDetails()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_EMR_NII_DETAILS]";
                IEnumerable<GET_EMR_NATURE_INJURY_DETAILS> objUserList = SqlMapper.Query<GET_EMR_NATURE_INJURY_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE AddEMRNII(ADD_EMR_NATURE_INJURY_MASTER _AddEMRNII)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@NATURE_INJURY_ID", _AddEMRNII.NATURE_INJURY_ID);
                param.Add("@NATURE_INJURY_NAME", _AddEMRNII.NATURE_INJURY_NAME);
                param.Add("@NATURE_INJURY_NAME_AR", _AddEMRNII.NATURE_INJURY_NAME_AR);
                param.Add("@STATUS", _AddEMRNII.STATUS);
                connection();
                con.Open();
                var query = "[USP_ADD_EMR_NII]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_EMR_NATURE_INJURY_MASTER GetEMRNIIEdit(string NATURE_INJURY_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@NATURE_INJURY_ID", NATURE_INJURY_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_EMR_NII]";
                var objUserList = SqlMapper.Query<ADD_EMR_NATURE_INJURY_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteEMRNII(string NATURE_INJURY_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@NATURE_INJURY_ID", NATURE_INJURY_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_EMR_NII]";
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

        #region [Mechanism of Injury / Illness]
        public IEnumerable<GET_EMR_MECH_INJURY_DETAILS> GetEMRMIIDetails()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_EMR_MII_DETAILS]";
                IEnumerable<GET_EMR_MECH_INJURY_DETAILS> objUserList = SqlMapper.Query<GET_EMR_MECH_INJURY_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE AddEMRMII(ADD_EMR_MECH_INJURY_MASTER _AddEMRMII)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MECH_INJURY_ID", _AddEMRMII.MECH_INJURY_ID);
                param.Add("@MECH_INJURY_NAME", _AddEMRMII.MECH_INJURY_NAME);
                param.Add("@MECH_INJURY_NAME_AR", _AddEMRMII.MECH_INJURY_NAME_AR);
                param.Add("@STATUS", _AddEMRMII.STATUS);
                connection();
                con.Open();
                var query = "[USP_ADD_EMR_MII]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_EMR_MECH_INJURY_MASTER GetEMRMIIEdit(string MECH_INJURY_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MECH_INJURY_ID", MECH_INJURY_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_EMR_MII]";
                var objUserList = SqlMapper.Query<ADD_EMR_MECH_INJURY_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteEMRMII(string MECH_INJURY_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MECH_INJURY_ID", MECH_INJURY_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_EMR_MII]";
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

        #region [Agency / Source of Injury / Illness]
        public IEnumerable<GET_EMR_AGENCY_INJURY_DETAILS> GetEMRAIIDetails()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_EMR_AII_DETAILS]";
                IEnumerable<GET_EMR_AGENCY_INJURY_DETAILS> objUserList = SqlMapper.Query<GET_EMR_AGENCY_INJURY_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE AddEMRAII(ADD_EMR_AGENCY_INJURY_MASTER _AddEMRAII)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AGENCY_INJURY_ID", _AddEMRAII.AGENCY_INJURY_ID);
                param.Add("@AGENCY_INJURY_NAME", _AddEMRAII.AGENCY_INJURY_NAME);
                param.Add("@AGENCY_INJURY_NAME_AR", _AddEMRAII.AGENCY_INJURY_NAME_AR);
                param.Add("@STATUS", _AddEMRAII.STATUS);
                connection();
                con.Open();
                var query = "[USP_ADD_EMR_AII]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_EMR_AGENCY_INJURY_MASTER GetEMRAIIEdit(string AGENCY_INJURY_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AGENCY_INJURY_ID", AGENCY_INJURY_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_EMR_AII]";
                var objUserList = SqlMapper.Query<ADD_EMR_AGENCY_INJURY_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteEMRAII(string AGENCY_INJURY_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AGENCY_INJURY_ID", AGENCY_INJURY_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_EMR_AII]";
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

        #region [ Body Location ]

        #region [Body Location Category Master]
        public IEnumerable<GET_EMR_BODY_LOC_CAT_DETAILS> GetemrBODYLOCCATdetails()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_EMR_BODY_LOC_CAT_DETAILS]";
                IEnumerable<GET_EMR_BODY_LOC_CAT_DETAILS> objUserList = SqlMapper.Query<GET_EMR_BODY_LOC_CAT_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE AddemrBODYLOCCAT(ADD_EMR_BODY_LOC_CAT_MASTER _AddEMRBODYLOCCAT)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BODY_LOC_CAT_ID", _AddEMRBODYLOCCAT.BODY_LOC_CAT_ID);
                param.Add("@BODY_LOC_CAT_NAME", _AddEMRBODYLOCCAT.BODY_LOC_CAT_NAME);
                param.Add("@BODY_LOC_CAT_NAME_AR", _AddEMRBODYLOCCAT.BODY_LOC_CAT_NAME_AR);
                param.Add("@STATUS", _AddEMRBODYLOCCAT.STATUS);
                connection();
                con.Open();
                var query = "[USP_ADD_EMR_BODY_LOC_CAT]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_EMR_BODY_LOC_CAT_MASTER GetemrBODYLOCCATedit(string BODY_LOC_CAT_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BODY_LOC_CAT_ID", BODY_LOC_CAT_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_EMR_BODY_LOC_CAT]";
                var objUserList = SqlMapper.Query<ADD_EMR_BODY_LOC_CAT_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteemrBODYLOCCAT(string BODY_LOC_CAT_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BODY_LOC_CAT_ID", BODY_LOC_CAT_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_EMR_BODY_LOC_CAT]";
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

        #region [Body Location]
        public IEnumerable<GET_EMR_BODY_LOC_DETAILS> GetEMRBodyLocDetails()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_EMR_BODY_LOC_DETAILS]";
                IEnumerable<GET_EMR_BODY_LOC_DETAILS> objUserList = SqlMapper.Query<GET_EMR_BODY_LOC_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE AddEMRBodyLoc(ADD_EMR_BODY_LOC_MASTER _AddEMRBodyLoc)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BODY_LOC_ID", _AddEMRBodyLoc.BODY_LOC_ID);
                param.Add("@BODY_LOC_CAT_ID", _AddEMRBodyLoc.BODY_LOC_CAT_ID);
                param.Add("@CAT_NAME_AR", _AddEMRBodyLoc.CAT_NAME_AR);
                param.Add("@SUB_CAT_NAME", _AddEMRBodyLoc.SUB_CAT_NAME);
                param.Add("@SUB_CAT_NAME_AR", _AddEMRBodyLoc.SUB_CAT_NAME_AR);
                param.Add("@STATUS", _AddEMRBodyLoc.STATUS);
                connection();
                con.Open();
                var query = "[USP_ADD_EMR_BODY_LOC]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_EMR_BODY_LOC_MASTER GetEMRBodyLocEdit(string BODY_LOC_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BODY_LOC_ID", BODY_LOC_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_EMR_BODY_LOC]";
                var objUserList = SqlMapper.Query<ADD_EMR_BODY_LOC_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteEMRBodyLoc(string BODY_LOC_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BODY_LOC_ID", BODY_LOC_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_EMR_BODY_LOC]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<GET_EMR_BODY_LOC_DETAILS> GET_BODY_LOCATION_SUBCAT(string CAT_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@CAT_ID", CAT_ID);
                connection();
                con.Open();
                var query = "[USP_GET_EMR_BODY_LOC_SUBCAT]";
                IEnumerable<GET_EMR_BODY_LOC_DETAILS> objUserList = SqlMapper.Query<GET_EMR_BODY_LOC_DETAILS>(con, query, param, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #endregion

        #region [Incident Cause Analysis]
        public IEnumerable<GET_EMR_INCDT_CA_DETAILS> GetemrINCDTCAdetails()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_INCDT_CA_DETAILS]";
                IEnumerable<GET_EMR_INCDT_CA_DETAILS> objUserList = SqlMapper.Query<GET_EMR_INCDT_CA_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE AddemrINCDTCA(ADD_EMR_INCDT_CA_MASTER _AddEMRINCDTCA)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@INCDT_CAS_ID", _AddEMRINCDTCA.INCDT_CAS_ID);
                param.Add("@INCDT_CAS_NAME", _AddEMRINCDTCA.INCDT_CAS_NAME);
                param.Add("@INCDT_CAS_NAME_AR", _AddEMRINCDTCA.INCDT_CAS_NAME_AR);
                param.Add("@STATUS", _AddEMRINCDTCA.STATUS);
                connection();
                con.Open();
                var query = "[USP_ADD_EMR_INCDT_CA]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_EMR_INCDT_CA_MASTER GetemrINCDTCAedit(string INCDT_CAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@INCDT_CAS_ID", INCDT_CAS_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_EMR_INCDT_CA]";
                var objUserList = SqlMapper.Query<ADD_EMR_INCDT_CA_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteemrINCDT(string INCDT_CAS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@INCDT_CAS_ID", INCDT_CAS_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_EMR_INCDT_CA]";
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


        #region [Risk Assessment Master]
        public IEnumerable<GET_EMR_RISK_ASS_MASTER_DETAILS> GetemrRISKASSMASTERdetails()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_EMR_RISK_ASS_MASTER_DETAILS]";
                IEnumerable<GET_EMR_RISK_ASS_MASTER_DETAILS> objUserList = SqlMapper.Query<GET_EMR_RISK_ASS_MASTER_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE AddEMRRISKASSMASTER(ADD_EMR_RISK_ASS_MASTER_MASTER _AddEMRRISKASSMASTER)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RISK_ASS_MASTER_ID", _AddEMRRISKASSMASTER.RISK_ASS_MASTER_ID);
                param.Add("@RISK_ASS_MASTER_NAME", _AddEMRRISKASSMASTER.RISK_ASS_MASTER_NAME);
                param.Add("@RISK_ASS_MASTER_NAME_AR", _AddEMRRISKASSMASTER.RISK_ASS_MASTER_NAME_AR);
                param.Add("@STATUS", _AddEMRRISKASSMASTER.STATUS);
                connection();
                con.Open();
                var query = "[USP_ADD_EMR_RISK_ASS_MASTER]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_EMR_RISK_ASS_MASTER_MASTER GetemrRISKASSMASTERedit(string RISK_ASS_MASTER_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RISK_ASS_MASTER_ID", RISK_ASS_MASTER_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_RISK_ASS_MASTER]";
                var objUserList = SqlMapper.Query<ADD_EMR_RISK_ASS_MASTER_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteemrRISKASSMASTER(string RISK_ASS_MASTER_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RISK_ASS_MASTER_ID", RISK_ASS_MASTER_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_EMR_RISK_ASS_MASTER]";
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

        #region [Risk Assessment]
        public IEnumerable<GET_EMR_RISK_ASSESSMENT_DETAILS> GetemrRISKASSdetails()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_EMR_RISK_ASSESSMENT]";
                IEnumerable<GET_EMR_RISK_ASSESSMENT_DETAILS> objUserList = SqlMapper.Query<GET_EMR_RISK_ASSESSMENT_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public RETURN_MESSAGE AddemrRISKASS(ADD_EMR_RISK_ASSESSMENT _AddEMRRISKASS)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RISK_ASS_ID", _AddEMRRISKASS.RISK_ASS_ID);
                param.Add("@RISK_ASS_MASTER_ID", _AddEMRRISKASS.RISK_ASS_MASTER_ID);
                param.Add("@RISK_ASS_POSSIBILITY", _AddEMRRISKASS.RISK_ASS_POSSIBILITY);
                param.Add("@STATUS", _AddEMRRISKASS.STATUS);
                connection();
                con.Open();
                var query = "[USP_ADD_EMR_RISK_ASSESSMENT]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_EMR_RISK_ASSESSMENT GetemrRISKASSedit(string RISK_ASS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RISK_ASS_ID", RISK_ASS_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_EMR_RISK_ASSESSMENT]";
                var objUserList = SqlMapper.Query<ADD_EMR_RISK_ASSESSMENT>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteemrRISKASS(string RISK_ASS_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RISK_ASS_ID", RISK_ASS_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_EMR_RISK_ASSESSMENT]";
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

        #region [INCIDENT_DETAILS]
        public IEnumerable<GET_INCIDENT_DETAILS> GetIncident()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_INCIDENT_DETAILS]";
                IEnumerable<GET_INCIDENT_DETAILS> objUserList = SqlMapper.Query<GET_INCIDENT_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteIncident(string INCID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@INC_ID", INCID);
                connection();
                con.Open();
                var query = "[USP_DELETE_INCIDENT_DETAILS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IncidentModel EditIncident(string INCID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@INC_ID", INCID);
                connection();
                con.Open();
                var query = "[USP_EDIT_INCIDENT_DETAILS]";
                var objUserList = SqlMapper.Query<IncidentModel>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE AddIncident(IncidentModel _INC_DETAILS)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@INC_ID", _INC_DETAILS.INC_ID);
                param.Add("@INC_CATEGORY", _INC_DETAILS.INC_CATEGORY);
                param.Add("@INC_DATE_TIME", _INC_DETAILS.INC_DATE_TIME);
                param.Add("@INC_NOTIFY_BY", _INC_DETAILS.INC_NOTIFY_BY);
                param.Add("@INC_DEPART_ID", _INC_DETAILS.INC_DEPART_ID);
                param.Add("@INC_LOC_ID", _INC_DETAILS.INC_LOC_ID);
                param.Add("@INC_SEC_ID", _INC_DETAILS.INC_SEC_ID);
                param.Add("@INC_SEC_LAB_ID", _INC_DETAILS.INC_SEC_LAB_ID);
                param.Add("@INC_BUIL_ID", _INC_DETAILS.INC_BUIL_ID);
                param.Add("@IS_PERSON_INVOLVED", _INC_DETAILS.IS_PERSON_INVOLVED);
                param.Add("@IS_FATALITY", _INC_DETAILS.IS_FATALITY);
                param.Add("@DESCRIPTION", _INC_DETAILS.DESCRIPTION);
                param.Add("@INC_TYPE", _INC_DETAILS.INC_TYPE);
                param.Add("@REPORTED_BY", _INC_DETAILS.REPORTED_BY);
                connection();
                con.Open();
                var query = "[USP_ADD_INCIDENT_DETAILS]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE AddPhotoUpload(List<UPLOAD_PHOTO_LIST> _UPLOAD_PHOTO)
        {
            try
            {
                connection();
                con.Open();
                con.Execute("USP_UPLOAD_PHOTOS_INCIDENT", _UPLOAD_PHOTO, commandType: CommandType.StoredProcedure);
                con.Close();
                RETURN_MESSAGE rETURN_MESSAGE = new RETURN_MESSAGE
                {
                    STATUS_CODE = "200",
                    MESSAGE = "Photo Added Successful"
                };
                return rETURN_MESSAGE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        #endregion

        #region [INC_CATEGORY_MASTER]
        public IEnumerable<GET_INCIDENT_CATEGORY_DETAILS> GetIncidentCategory()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_INCCATEGORY_MASTER]";
                IEnumerable<GET_INCIDENT_CATEGORY_DETAILS> objUserList = SqlMapper.Query<GET_INCIDENT_CATEGORY_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteIncidentCategory(string INCCATID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@INCCATID", INCCATID);
                connection();
                con.Open();
                var query = "[USP_DELETE_INCCATEGORY]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IncidentCategoryModel GetIncidentCategoryEdit(string INCCATID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@INCCATID", INCCATID);
                connection();
                con.Open();
                var query = "[USP_EDIT_INCCATEGORY]";
                var objUserList = SqlMapper.Query<IncidentCategoryModel>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE AddIncidentCategory(IncidentCategoryModel _INC_CAT_MASTER)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@INCCATID", _INC_CAT_MASTER.INC_CAT_ID);
                param.Add("@INCCATNAME", _INC_CAT_MASTER.INC_CAT_NAME);
                param.Add("@INCCATNAMEAR", _INC_CAT_MASTER.INC_CAT_NAME_AR);
                connection();
                con.Open();
                var query = "[USP_ADD_INCCATEGORY]";
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

        #region [ADD_INVESTIGATION]
        public RETURN_MESSAGE ADD_INVESTIGATION(INVESTCATION_DETAILS _INVESTIGATION_DETAILS)
        {
            try
            {
                connection();
                con.Open();
                con.Execute("USP_ADD_INVE_IM_CASUSE_ACT", _INVESTIGATION_DETAILS.INVE_IM_CASUE_ACT, commandType: CommandType.StoredProcedure);
                con.Execute("USP_ADD_INVE_IM_CASUSE_UNC", _INVESTIGATION_DETAILS.INVE_IM_CASUE_UNC, commandType: CommandType.StoredProcedure);
                con.Execute("USP_ADD_INVE_ROOT_PF_CAUSE", _INVESTIGATION_DETAILS.INVE_IM_ROOT_PF, commandType: CommandType.StoredProcedure);
                con.Execute("USP_ADD_INVE_ROOT_SF_CAUSE", _INVESTIGATION_DETAILS.INVE_IM_ROOT_SF, commandType: CommandType.StoredProcedure);
                con.Execute("USP_ADD_INVE_NATURE_INJURY_CAUSE", _INVESTIGATION_DETAILS.INVE_NATURE_OF_INJURY, commandType: CommandType.StoredProcedure);
                con.Execute("USP_ADD_INVE_MECH_INJURY_CAUSE", _INVESTIGATION_DETAILS.INVE_MECHANISM_OF_INJURY, commandType: CommandType.StoredProcedure);
                con.Execute("USP_ADD_INVE_SOURCE_INJURY_CAUSE", _INVESTIGATION_DETAILS.INVE_SOURCE_OF_INJURY, commandType: CommandType.StoredProcedure);
                con.Execute("USP_ADD_INVE_BODY_LOC_CAUSE", _INVESTIGATION_DETAILS.INVE_BODY_LOC_CASUE, commandType: CommandType.StoredProcedure);
                con.Execute("USP_ADD_INVE_ACTION_TAKEN_IMMEDIATELY", _INVESTIGATION_DETAILS.ACTION_TAKEN_IMMEDIATELY, commandType: CommandType.StoredProcedure);
                con.Execute("USP_ADD_INVE_INCIDENT_ROOT_CAUSE", _INVESTIGATION_DETAILS.INCIDENT_ROOT_CAUSE, commandType: CommandType.StoredProcedure);
                con.Execute("USP_ADD_INVE_CORRECTIVE_ACTION", _INVESTIGATION_DETAILS.CORRECTIVE_ACTION, commandType: CommandType.StoredProcedure);
                con.Execute("USP_ADD_INVE_INCIDENT_COST_ANALYSIS", _INVESTIGATION_DETAILS.INCIDENT_COST_ANALYSIS, commandType: CommandType.StoredProcedure);
                con.Execute("USP_ADD_INVE_INJURED_PERSONAL_DETAILS", _INVESTIGATION_DETAILS.INJURED_PERSONAL_DETAILS, commandType: CommandType.StoredProcedure);
                con.Execute("USP_ADD_INVE_RISK_ASSESSMENT_DETAILS", _INVESTIGATION_DETAILS.RISK_ASSESSMENT_DETAILS, commandType: CommandType.StoredProcedure);
                con.Execute("USP_ADD_INVE_DECLARATION_INJURED_PERSON", _INVESTIGATION_DETAILS.DECLARATION_INJURED_PERSON, commandType: CommandType.StoredProcedure);
                con.Close();
                RETURN_MESSAGE rETURN_MESSAGE = new RETURN_MESSAGE
                {
                    STATUS_CODE = "200",
                    MESSAGE = "Incident Investigation Added Successful"
                };
                return rETURN_MESSAGE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
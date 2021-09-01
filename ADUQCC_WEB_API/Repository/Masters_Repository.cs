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

    public class Masters_Repository
    {
        public SqlConnection con;
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["ADUQCC_WEB_API"].ToString();
            con = new SqlConnection(constr);
        }

        #region [SELECT_DROPDOWN_METHODS]
        public IEnumerable<GET_BUILDING_MASTER> GetBuildingMasterSelect(string LOCID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@LOCID", LOCID);
                connection();
                con.Open();
                var query = "[USP_GET_BUILDING_MASTER_SELECT]";
                IEnumerable<GET_BUILDING_MASTER> objUserList = SqlMapper.Query<GET_BUILDING_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<GET_DEPARTMENT_MASTER> GetDepartmentMasterSelect(string SECID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SECID", SECID);
                connection();
                con.Open();
                var query = "[USP_GET_DEPARTMENT_MASTER_SELECT]";
                IEnumerable<GET_DEPARTMENT_MASTER> objUserList = SqlMapper.Query<GET_DEPARTMENT_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<GET_SECTION_LAB_MASTER> GetSectionLabMasterSelect(string DEPID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@DEPID", DEPID);
                connection();
                con.Open();
                var query = "[USP_GET_SECTION_LAB_MASTER_SELECT]";
                IEnumerable<GET_SECTION_LAB_MASTER> objUserList = SqlMapper.Query<GET_SECTION_LAB_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<GET_SECTOR_DETAILS> GetSectorMasterSelect(string BUILID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BUILID", BUILID);
                connection();
                con.Open();
                var query = "[USP_GET_SECTOR_MASTER_SELECT]";
                IEnumerable<GET_SECTOR_DETAILS> objsector = SqlMapper.Query<GET_SECTOR_DETAILS>(con, query, param, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objsector;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<GET_SECTOR_DETAILS> GetSectorMasterSelect_Dep()
        {
            try
            {
                connection();
                con.Open();
                var query = "[USP_GET_SECTOR_MASTER_SELECT_DEP]";
                IEnumerable<GET_SECTOR_DETAILS> objsector = SqlMapper.Query<GET_SECTOR_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objsector;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<GET_DEPARTMENT_MASTER> _GetDepartmentMasterSelect_Lab(string SEC_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SEC_ID", SEC_ID);
                connection();
                con.Open();
                var query = "[USP_GET_DEPARTMENT_MASTER_SELECT_LAB]";
                IEnumerable<GET_DEPARTMENT_MASTER> objsector = SqlMapper.Query<GET_DEPARTMENT_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objsector;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        #endregion

        #region [LOCATION_MASTER]
        public IEnumerable<GET_LOCATION_MASTER> GetLocationMaster()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_LOCATION_MASTER]";
                IEnumerable<GET_LOCATION_MASTER> objUserList = SqlMapper.Query<GET_LOCATION_MASTER>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteLoaction(string LOC_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@LOC_ID", LOC_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_LOACTION]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_LOCATION_MASTER GetLoactionEdit(string LOC_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@LOC_ID", LOC_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_LOCATION]";
                var objUserList = SqlMapper.Query<ADD_LOCATION_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE AddLocation(ADD_LOCATION_MASTER _LOCATION_MASTER)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@LOC_ID", _LOCATION_MASTER.LOC_ID);
                param.Add("@LOC_NAME", _LOCATION_MASTER.LOC_NAME);
                param.Add("@LOC_NAME_AR", _LOCATION_MASTER.LOC_NAME_AR);
                connection();
                con.Open();
                var query = "[USP_ADD_LOCATION]";
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

        #region [BUILDING_MASTER]
        public IEnumerable<GET_BUILDING_MASTER> GetBuilding()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_BUILDING_MASTER]";
                IEnumerable<GET_BUILDING_MASTER> objUserList = SqlMapper.Query<GET_BUILDING_MASTER>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteBuilding(string BUIL_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BUIL_ID", BUIL_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_BULIDING]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_BUILDING_MASTER GetBuildingEdit(string BUIL_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BUIL_ID", BUIL_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_BUILDING]";
                var objUserList = SqlMapper.Query<ADD_BUILDING_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE AddBuilding(ADD_BUILDING_MASTER _BUILDING_MASTER)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BUIL_ID", _BUILDING_MASTER.BUIL_ID);
                param.Add("@LOC_ID", _BUILDING_MASTER.LOC_ID);
                param.Add("@BUIL_NAME", _BUILDING_MASTER.BUIL_NAME);
                param.Add("@BUIL_NAME_AR", _BUILDING_MASTER.BUIL_NAME_AR);
                connection();
                con.Open();
                var query = "[USP_ADD_BUILDING]";
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

        #region [DEPARTMENT_MASTER]
        public IEnumerable<GET_DEPARTMENT_MASTER> GetDepartmentMaster()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_DEPARTMENT_MASTER]";
                IEnumerable<GET_DEPARTMENT_MASTER> objUserList = SqlMapper.Query<GET_DEPARTMENT_MASTER>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteDepartment(string DEP_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@DEP_ID", DEP_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_DEPARTMENT]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_DEPARTMENT_MASTER GetDepartmentEdit(string DEP_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@DEP_ID", DEP_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_DEPRATMENT]";
                var objUserList = SqlMapper.Query<ADD_DEPARTMENT_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE AddDepartment(ADD_DEPARTMENT_MASTER _DEPARTMENT_MASTER)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@DEP_ID", _DEPARTMENT_MASTER.DEP_ID);
                param.Add("@SEC_ID", _DEPARTMENT_MASTER.SEC_ID);
                param.Add("@DEP_NAME", _DEPARTMENT_MASTER.DEP_NAME);
                param.Add("@DEP_NAME_AR", _DEPARTMENT_MASTER.DEP_NAME_AR);
                connection();
                con.Open();
                var query = "[USP_ADD_DEPARTMENT]";
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

        #region [SECTION_LAB_MASTER]
        public IEnumerable<GET_SECTION_LAB_MASTER> GetSectionLabMaster()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                connection();
                con.Open();
                var query = "[USP_GET_SECTION_LAB_MASTER]";
                IEnumerable<GET_SECTION_LAB_MASTER> objUserList = SqlMapper.Query<GET_SECTION_LAB_MASTER>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objUserList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE DeleteSectionLab(string SEC_LAB_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SEC_LAB_ID", SEC_LAB_ID);
                connection();
                con.Open();
                var query = "[USP_DELETE_DEPARTMENT]";
                var objUserList = SqlMapper.Query<RETURN_MESSAGE>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ADD_SECTION_LAB_MASTER GetDSectionLabEdit(string SEC_LAB_ID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SEC_LAB_ID", SEC_LAB_ID);
                connection();
                con.Open();
                var query = "[USP_EDIT_SECTION_LAB]";
                var objUserList = SqlMapper.Query<ADD_SECTION_LAB_MASTER>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objUserList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RETURN_MESSAGE AddSectionLab(ADD_SECTION_LAB_MASTER _SECTION_LAB_MASTER)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SEC_LAB_ID", _SECTION_LAB_MASTER.SEC_LAB_ID);
                param.Add("@SEC_LAB_TYPE", _SECTION_LAB_MASTER.SEC_LAB_TYPE);
                param.Add("@DEP_ID", _SECTION_LAB_MASTER.DEP_ID);
                param.Add("@SEC_LAB_NAME", _SECTION_LAB_MASTER.SEC_LAB_NAME);
                param.Add("@SEC_LAB_NAME_AR", _SECTION_LAB_MASTER.SEC_LAB_NAME_AR);
                connection();
                con.Open();
                var query = "[USP_ADD_SECTION_LAB]";
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

        #region [SECTOR_TYPE_MASTER]
        public List<GET_SECTORTYPE_DETAILS> GetSectorTypeDetails()
        {
            try
            {
                connection();
                con.Open();
                var query = "[USP_GET_SECTORTYPE]";
                var objSecTypeList = SqlMapper.Query<GET_SECTORTYPE_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objSecTypeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SectorTypeModel AddSectorTypeDetails(SectorTypeModel model)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SECTYPEID", model.SEC_TYPE_ID);
                param.Add("@@SECTYPENAMEEN", model.SEC_TYPE_NAME_EN);
                param.Add("@SECTYPENAMEARB", model.SEC_TYPE_NAME_ARB);
                connection();
                con.Open();
                var query = "[USP_ADD_SECTORTYPE]";
                var objsectype = SqlMapper.Query<SectorTypeModel>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objsectype;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SectorTypeModel DeleteSectorTypeDetails(string SECTYPEID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SECTYPEID", SECTYPEID);
                connection();
                con.Open();
                var query = "[USP_DELETE_SECTORTYPE]";
                var objsectype = SqlMapper.Query<SectorTypeModel>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objsectype;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SectorTypeModel EditSectorTypeDetails(string SECTYPEID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SECTYPEID", SECTYPEID);
                connection();
                con.Open();
                var query = "[USP_EDIT_SECTORTYPE]";
                var objsectype = SqlMapper.Query<SectorTypeModel>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objsectype;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region [SECTOR_MASTER]
        public List<GET_SECTOR_DETAILS> GetSectorDetails()
        {
            try
            {
                connection();
                con.Open();
                var query = "[USP_GET_SECTOR]";
                var objSecList = SqlMapper.Query<GET_SECTOR_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objSecList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SectorModel AddSectorDetails(SectorModel model)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SECID", model.SEC_ID);
                param.Add("@SECTYPEID", model.SEC_TYPE);
                param.Add("@BUILID", model.BUIL_ID);
                param.Add("@@SECNAMEEN", model.SEC_NAME_EN);
                param.Add("@SECNAMEARB", model.SEC_NAME_ARB);
                connection();
                con.Open();
                var query = "[USP_ADD_SECTOR]";
                var objsector = SqlMapper.Query<SectorModel>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objsector;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SectorModel DeleteSectorDetails(string SECID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SECID", SECID);
                connection();
                con.Open();
                var query = "[USP_DELETE_SECTOR]";
                var objsector = SqlMapper.Query<SectorModel>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objsector;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SectorModel EditSectorDetails(string SECID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SECID", SECID);
                connection();
                con.Open();
                var query = "[USP_EDIT_SECTOR]";
                var objsector = SqlMapper.Query<SectorModel>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objsector;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region DESIGNATION_MASTER
        public List<GET_DESIGNATION_DETAILS> GetDesignationDetails()
        {
            try
            {
                connection();
                con.Open();
                var query = "[USP_GET_DESIGNATION]";
                var objDesiList = SqlMapper.Query<GET_DESIGNATION_DETAILS>(con, query, commandType: CommandType.StoredProcedure).ToList();
                con.Close();
                return objDesiList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DesignationModel AddDesignationDetails(DesignationModel model)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@DESIID", model.DESI_ID);
                param.Add("@@DESINAMEEN", model.DESI_NAME_EN);
                param.Add("@DESINAMEARB", model.DESI_NAME_ARB);
                connection();
                con.Open();
                var query = "[USP_ADD_DESIGNATION]";
                var objdesi = SqlMapper.Query<DesignationModel>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objdesi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DesignationModel DeleteDesignationDetails(string DESIID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@DESIID", DESIID);
                connection();
                con.Open();
                var query = "[USP_DELETE_DESIGNATION]";
                var objdesi = SqlMapper.Query<DesignationModel>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objdesi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DesignationModel EditDesignationDetails(string DESIID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@DESIID", DESIID);
                connection();
                con.Open();
                var query = "[USP_EDIT_DESIGNATION]";
                var objdesi = SqlMapper.Query<DesignationModel>(con, query, param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                con.Close();
                return objdesi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
using ADUQCC_WEB_API.Models;
using ADUQCC_WEB_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ADUQCC_WEB_API.Controllers
{
    [RoutePrefix("api/Masters")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MastersController : ApiController
    {

        #region [LOCATION_MASTER]
        [Route("GetLocation")]
        // GET: api/Masters
        public IEnumerable<GET_LOCATION_MASTER> GetLocationMaster()
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.GetLocationMaster();
        }

        [Route("AddLocation")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddLocation(ADD_LOCATION_MASTER _LOCATION_MASTER)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.AddLocation(_LOCATION_MASTER);
        }

        [Route("DeleteLoaction")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteLoaction(string LOC_ID)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.DeleteLoaction(LOC_ID);
        }

        [Route("GetLoactionEdit")]
        //GET: api/UserDetails
        public ADD_LOCATION_MASTER GetLoactionEdit(string LOC_ID)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.GetLoactionEdit(LOC_ID);
        }

        [Route("UpdateLocation")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT(ADD_LOCATION_MASTER _LOCATION_MASTER)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.AddLocation(_LOCATION_MASTER);
        }
        #endregion

        #region [BUILDING_MASTER]
        [Route("GetBuilding")]
        // GET: api/Masters
        public IEnumerable<GET_BUILDING_MASTER> GetBuilding()
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.GetBuilding();
        }

        [Route("AddBuilding")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddBuilding(ADD_BUILDING_MASTER _BUILDING_MASTER)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.AddBuilding(_BUILDING_MASTER);
        }

        [Route("DeleteBuilding")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteBuilding(string BUIL_ID)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.DeleteBuilding(BUIL_ID);
        }

        [Route("GetBuildingEdit")]
        //GET: api/UserDetails
        public ADD_BUILDING_MASTER GetBuildingEdit(string BUIL_ID)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.GetBuildingEdit(BUIL_ID);
        }

        [Route("UpdateBuilding")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUTUpdateBuilding(ADD_BUILDING_MASTER _BUILDING_MASTER)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.AddBuilding(_BUILDING_MASTER);
        }
        #endregion

        #region [DEPARTMENT_MASTER]

        [Route("GetDepartment")]
        // GET: api/Masters
        public IEnumerable<GET_DEPARTMENT_MASTER> GetDepartmentMaster()
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.GetDepartmentMaster();
        }

        [Route("AddDepartment")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddDepartment(ADD_DEPARTMENT_MASTER _DEPARTMENT_MASTER)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.AddDepartment(_DEPARTMENT_MASTER);
        }

        [Route("DeleteDepartment")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteDepartment(string DEP_ID)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.DeleteDepartment(DEP_ID);
        }

        [Route("GetDepartmentEdit")]
        //GET: api/UserDetails
        public ADD_DEPARTMENT_MASTER GetDepartmentEdit(string DEP_ID)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.GetDepartmentEdit(DEP_ID);
        }

        [Route("UpdateDepartment")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUTDepartment(ADD_DEPARTMENT_MASTER _DEPARTMENT_MASTER)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.AddDepartment(_DEPARTMENT_MASTER);
        }
        #endregion

        #region [SECTION_LAB_MASTER]
        [Route("GetSectionLab")]
        // GET: api/Masters
        public IEnumerable<GET_SECTION_LAB_MASTER> GetSectionLabMaster()
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.GetSectionLabMaster();
        }

        [Route("AddSectionLab")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddSectionLab(ADD_SECTION_LAB_MASTER _SECTION_LAB_MASTER)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.AddSectionLab(_SECTION_LAB_MASTER);
        }

        [Route("DeleteSectionLab")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteSectionLab(string SEC_LAB_ID)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.DeleteSectionLab(SEC_LAB_ID);
        }

        [Route("GetSectionLabEdit")]
        //GET: api/UserDetails
        public ADD_SECTION_LAB_MASTER GetSectionLabEdit(string SEC_LAB_ID)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.GetDSectionLabEdit(SEC_LAB_ID);
        }

        [Route("UpdateSectionLab")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUTSectionLab(ADD_SECTION_LAB_MASTER _SECTION_LAB_MASTER)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.AddSectionLab(_SECTION_LAB_MASTER);
        }
        #endregion

        #region [SECTOR_TYPE_MASATER]
        [Route("GetSectorTypeDetails")]
        // GET: api/LocationDetails
        public List<GET_SECTORTYPE_DETAILS> GetSectorTypeDetails()
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.GetSectorTypeDetails();
        }

        [Route("AddSectorType")]
        // POST: api/AddSectorTypeDetails
        public SectorTypeModel AddSectorType(SectorTypeModel model)
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.AddSectorTypeDetails(model);
        }
        [Route("UpdateSectorType")]
        // Put: api/UpdateSectorTypeDetails
        public SectorTypeModel PutSectorType(SectorTypeModel model)
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.AddSectorTypeDetails(model);
        }

        [Route("DeleteSectorType")]
        // Delete: api/DeleteSectorTypeDetails
        public SectorTypeModel DeleteSectorType(string SECTYPEID)
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.DeleteSectorTypeDetails(SECTYPEID);
        }

        [Route("EditSectorType")]
        // Get: api/EditSectorTypeDetails
        public SectorTypeModel GETSectorType(string SECTYPEID)
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.EditSectorTypeDetails(SECTYPEID);
        }

        [Route("GetSectorDetails")]
        // GET: api/LocationDetails
        public List<GET_SECTOR_DETAILS> GetSectorDetails()
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.GetSectorDetails();
        }

        #endregion

        #region [SECTOR_MASTER]
        [Route("AddSector")]
        // POST: api/AddSectorDetails
        public SectorModel AddSector(SectorModel model)
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.AddSectorDetails(model);
        }
        [Route("UpdateSector")]
        // Put: api/UpdateSectorDetails
        public SectorModel PutSector(SectorModel model)
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.AddSectorDetails(model);
        }

        [Route("DeleteSector")]
        // Delete: api/DeleteSectorDetails
        public SectorModel DeleteSector(string SECID)
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.DeleteSectorDetails(SECID);
        }

        [Route("EditSector")]
        // Get: api/EditSectorDetails
        public SectorModel GETSector(string SECID)
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.EditSectorDetails(SECID);
        }
        #endregion

        #region DESIGNATION_MASTER
        [Route("GetDesignationDetails")]
        // GET: api/DesignationDetails
        public List<GET_DESIGNATION_DETAILS> GetDesignationDetails()
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.GetDesignationDetails();
        }

        [Route("AddDesignation")]
        // POST: api/AddDesignationDetails
        public DesignationModel AddDesignation(DesignationModel model)
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.AddDesignationDetails(model);
        }
        [Route("UpdateDesignation")]
        // Put: api/UpdateDesignationDetails
        public DesignationModel PutDesignation(DesignationModel model)
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.AddDesignationDetails(model);
        }

        [Route("DeleteDesignation")]
        // Delete: api/DeleteDesignationDetails
        public DesignationModel DeleteDesignation(string DESIID)
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.DeleteDesignationDetails(DESIID);
        }

        [Route("EditDesignation")]
        // Get: api/EditDesignationDetails
        public DesignationModel GETDesignation(string DESIID)
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.EditDesignationDetails(DESIID);
        }
        #endregion

        #region [SELECT MASTERS DROPDOWNS]
        [Route("GetBuildingMasterSelect")]
        // GET: api/Masters
        public IEnumerable<GET_BUILDING_MASTER> GetBuildingMasterSelect(string LOCID)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.GetBuildingMasterSelect(LOCID);
        }

        [Route("GetDepartmentMasterSelect")]
        // GET: api/Masters
        public IEnumerable<GET_DEPARTMENT_MASTER> GetDepartmentMasterSelect(string SECID)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.GetDepartmentMasterSelect(SECID);
        }

        [Route("GetSectionLabMasterSelect")]
        // GET: api/Masters
        public IEnumerable<GET_SECTION_LAB_MASTER> GetSectionLabMasterSelect(string DEPID)
        {
            Masters_Repository _mastersRepo = new Masters_Repository();
            return _mastersRepo.GetSectionLabMasterSelect(DEPID);
        }
        [Route("GetSectorMasterSelect")]
        // GET: api/SectorDetails
        public IEnumerable<GET_SECTOR_DETAILS> GetSectorMasterSelect(string BUILID)
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.GetSectorMasterSelect(BUILID);
        }

        [Route("GetSectorMasterSelect_Dep")]
        // GET: api/SectorDetails
        public IEnumerable<GET_SECTOR_DETAILS> GetSectorMasterSelect_Dep()
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo.GetSectorMasterSelect_Dep();
        }

        [Route("GetDepartmentMasterSelect_Lab")]
        // GET: api/SectorDetails
        public IEnumerable<GET_DEPARTMENT_MASTER> GetDepartmentMasterSelect_Lab(string SEC_ID)
        {
            Masters_Repository _masterRepo = new Masters_Repository();
            return _masterRepo._GetDepartmentMasterSelect_Lab(SEC_ID);
        }
        #endregion
    }
}

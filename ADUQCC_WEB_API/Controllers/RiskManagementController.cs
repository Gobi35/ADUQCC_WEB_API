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
    [RoutePrefix("api/RiskManagement")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RiskManagementController : ApiController
    {

        #region [Risk Category Master]


        [Route("GETRMRISKCATMAS")]
        public IEnumerable<GET_RM_RISK_CAT_MASTER> GETRMRISKCATMAS()
        {
            RiskManagement_Repository _GETRMRISKCATMAS = new RiskManagement_Repository();
            return _GETRMRISKCATMAS.GETRMRISKCATMAS();
        }

        [Route("ADDRMRISKCATMAS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE ADDRMRISKCATMAS(ADD_RM_RISK_CAT_MASTER _ADDRMRISKCATMASTER)
        {
            RiskManagement_Repository __ADDRMRISKCATMASREPO = new RiskManagement_Repository();
            return __ADDRMRISKCATMASREPO.ADDRMRISKCATMAS(_ADDRMRISKCATMASTER);
        }

        [Route("UPDATERMRISKCATMAS")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_RMRISKCATMAS(ADD_RM_RISK_CAT_MASTER _UPDATERMRISKCATMASTER)
        {
            RiskManagement_Repository _UPDATERMRISKCATMASREPO = new RiskManagement_Repository();
            return _UPDATERMRISKCATMASREPO.ADDRMRISKCATMAS(_UPDATERMRISKCATMASTER);
        }

        [Route("GETEDITRMRISKCATMAS")]
        //GET: api/UserDetails
        public ADD_RM_RISK_CAT_MASTER GETEDITRMRISKCATMAS(string RISK_CAT_MAS_ID)
        {
            RiskManagement_Repository _EDITRMRISKCATMASREPO = new RiskManagement_Repository();
            return _EDITRMRISKCATMASREPO.GETEDITRMRISKCATMAS(RISK_CAT_MAS_ID);
        }

        [Route("DELETERMRISKCATMAS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DELETERMRISKCATMAS(string RISK_CAT_MAS_ID)
        {
            RiskManagement_Repository _DELETERMRISKCATMASREPO = new RiskManagement_Repository();
            return _DELETERMRISKCATMASREPO.DELETERMRISKCATMAS(RISK_CAT_MAS_ID);
        }

        #endregion

        #region [Hazard Master]


        [Route("GETRMHAZARDMAS")]
        public IEnumerable<GET_RM_HAZARD_MASTER> GETRMHAZARDMAS()
        {
            RiskManagement_Repository _GETRMHAZARDMASREPO = new RiskManagement_Repository();
            return _GETRMHAZARDMASREPO.GETRMHAZARDMASREPO();
        }

        [Route("ADDRMHAZARDMAS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE ADDRMHAZARDMAS(ADD_RM_HAZARD_MASTER _ADDRMHAZARDMASTER)
        {
            RiskManagement_Repository __ADDRMHAZARDMASREPO = new RiskManagement_Repository();
            return __ADDRMHAZARDMASREPO.ADDRMHAZARDMASREPO(_ADDRMHAZARDMASTER);
        }

        [Route("UPDATERMHAZARDMAS")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_RMHAZARDMAS(ADD_RM_HAZARD_MASTER _UPDATERMHAZARDMASTER)
        {
            RiskManagement_Repository _UPDATERMHAZARDMASREPO = new RiskManagement_Repository();
            return _UPDATERMHAZARDMASREPO.ADDRMHAZARDMASREPO(_UPDATERMHAZARDMASTER);
        }

        [Route("GETEDITRMHAZARDMAS")]
        //GET: api/UserDetails
        public ADD_RM_HAZARD_MASTER GETEDITRMHAZARDMAS(string HAZARD_MAS_ID)
        {
            RiskManagement_Repository _EDITRMHAZARDMASREPO = new RiskManagement_Repository();
            return _EDITRMHAZARDMASREPO.GETEDITRMHAZARDMASREPO(HAZARD_MAS_ID);
        }

        [Route("DELETERMHAZARDMAS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DELETERMHAZARDMAS(string HAZARD_MAS_ID)
        {
            RiskManagement_Repository _DELETERMHAZARDMASREPO = new RiskManagement_Repository();
            return _DELETERMHAZARDMASREPO.DELETERMHAZARDMASREPO(HAZARD_MAS_ID);
        }

        #endregion

        #region [Risks And Other Risks]

        [Route("GETHAZARDSELECT")]
        //GET: api/UserDetails
        public IEnumerable<GET_RM_HAZARD_MASTER> GETHAZARDSELECT(string HAZ_RISK_CAT_MAS_ID)
        {
            RiskManagement_Repository _GETHAZARDSELECTREPO = new RiskManagement_Repository();
            return _GETHAZARDSELECTREPO.GETHAZARDSELECTREPO(HAZ_RISK_CAT_MAS_ID);
        }


        [Route("GETRMRISKOTHERRISK")]
        public IEnumerable<GET_RM_RISKS_OTHER_RISKS> GETRMRISKOTHERRISK()
        {
            RiskManagement_Repository _GETRMRISKOTHERRISKREPO = new RiskManagement_Repository();
            return _GETRMRISKOTHERRISKREPO.GETRMRISKOTHERRISKREPO();
        }

        [Route("ADDRMRISKOTHERRISK")]
        // GET: api/UserDetails
        public RETURN_MESSAGE ADDRMRISKOTHERRISK(ADD_RM_RISKS_OTHER_RISKS _ADDRMRISKOTHERRISK)
        {
            RiskManagement_Repository __ADDRMRISKOTHERRISKREPO = new RiskManagement_Repository();
            return __ADDRMRISKOTHERRISKREPO.ADDRMRISKOTHERRISKREPO(_ADDRMRISKOTHERRISK);
        }

        [Route("UPDATERMRISKOTHERRISK")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_RMRISKOTHERRISK(ADD_RM_RISKS_OTHER_RISKS _UPDATERMRISKOTHERRISK)
        {
            RiskManagement_Repository _UPDATERMRISKOTHERRISKREPO = new RiskManagement_Repository();
            return _UPDATERMRISKOTHERRISKREPO.ADDRMRISKOTHERRISKREPO(_UPDATERMRISKOTHERRISK);
        }

        [Route("GETEDITRMRISKOTHERRISK")]
        //GET: api/UserDetails
        public ADD_RM_RISKS_OTHER_RISKS GETEDITRMRISKOTHERRISK(string RISKS_OTHER_RISKS_ID)
        {
            RiskManagement_Repository _EDITRMRISKOTHERRISKREPO = new RiskManagement_Repository();
            return _EDITRMRISKOTHERRISKREPO.GETEDITRMRISKOTHERRISKREPO(RISKS_OTHER_RISKS_ID);
        }

        [Route("DELETERMRISKOTHERRISK")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DELETERMRISKOTHERRISK(string RISKS_OTHER_RISKS_ID)
        {
            RiskManagement_Repository _DELETERMRISKOTHERRISKREPO = new RiskManagement_Repository();
            return _DELETERMRISKOTHERRISKREPO.DELETERMRISKOTHERRISKREPO(RISKS_OTHER_RISKS_ID);
        }

        #endregion

        #region [Persons/Groups Exposed]


        [Route("GETRMPERSONSGROUPS")]
        public IEnumerable<GET_RM_PERSONS_GROUPS> GETRMPERSONSGROUPS()
        {
            RiskManagement_Repository _GETRMPERSONSGROUPSREPO = new RiskManagement_Repository();
            return _GETRMPERSONSGROUPSREPO.GETRMPERSONSGROUPSREPO();
        }

        [Route("ADDRMPERSONSGROUPS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE ADDRMPERSONSGROUPS(ADD_RM_PERSONS_GROUPS _ADDRMPERSONSGROUPS)
        {
            RiskManagement_Repository __ADDRMPERSONSGROUPSREPO = new RiskManagement_Repository();
            return __ADDRMPERSONSGROUPSREPO.ADDRMPERSONSGROUPSREPO(_ADDRMPERSONSGROUPS);
        }

        [Route("UPDATERMPERSONSGROUPS")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_RMPERSONSGROUPS(ADD_RM_PERSONS_GROUPS _UPDATERMPERSONSGROUPS)
        {
            RiskManagement_Repository _UPDATERMPERSONSGROUPSREPO = new RiskManagement_Repository();
            return _UPDATERMPERSONSGROUPSREPO.ADDRMPERSONSGROUPSREPO(_UPDATERMPERSONSGROUPS);
        }

        [Route("GETEDITRMPERSONSGROUPS")]
        //GET: api/UserDetails
        public ADD_RM_PERSONS_GROUPS GETEDITRMPERSONSGROUPS(string PERSON_GROUP_ID)
        {
            RiskManagement_Repository _EDITRMPERSONSGROUPSREPO = new RiskManagement_Repository();
            return _EDITRMPERSONSGROUPSREPO.GETEDITRMPERSONSGROUPSREPO(PERSON_GROUP_ID);
        }

        [Route("DELETERMPERSONSGROUPS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DELETERMPERSONSGROUPS(string PERSON_GROUP_ID)
        {
            RiskManagement_Repository _DELETERMPERSONSGROUPSREPO = new RiskManagement_Repository();
            return _DELETERMPERSONSGROUPSREPO.DELETERMPERSONSGROUPSREPO(PERSON_GROUP_ID);
        }

        #endregion

        #region [Details of any Existing Controls]


        [Route("GETDEC")]
        public IEnumerable<GET_RM_DETAILS_EXIST_CONT> GETDEC()
        {
            RiskManagement_Repository _GETDECREPO = new RiskManagement_Repository();
            return _GETDECREPO.GETDECREPO();
        }

        [Route("ADDDEC")]
        // GET: api/UserDetails
        public RETURN_MESSAGE ADDDEC(ADD_RM_DETAILS_EXIST_CONT _ADDDEC)
        {
            RiskManagement_Repository __ADDDECREPO = new RiskManagement_Repository();
            return __ADDDECREPO.ADDDECREPO(_ADDDEC);
        }

        [Route("UPDATEDEC")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_DEC(ADD_RM_DETAILS_EXIST_CONT _UPDATEDEC)
        {
            RiskManagement_Repository _UPDATEDECREPO = new RiskManagement_Repository();
            return _UPDATEDECREPO.ADDDECREPO(_UPDATEDEC);
        }

        [Route("GETEDITDEC")]
        //GET: api/UserDetails
        public ADD_RM_DETAILS_EXIST_CONT GETEDITDEC(string DETAILS_EXIST_CONT_ID)
        {
            RiskManagement_Repository _EDITDECREPO = new RiskManagement_Repository();
            return _EDITDECREPO.GETEDITDECREPO(DETAILS_EXIST_CONT_ID);
        }

        [Route("DELETEDEC")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DELETEDEC(string DETAILS_EXIST_CONT_ID)
        {
            RiskManagement_Repository _DELETEDECREPO = new RiskManagement_Repository();
            return _DELETEDECREPO.DELETEDECREPO(DETAILS_EXIST_CONT_ID);
        }

        #endregion

        #region [Critical Hazard Master]

        [Route("GETRMCRITHAZARDMAS")]
        public IEnumerable<GET_RM_CRIT_HAZARD_MASTER> GETRMCRITHAZARDMAS()
        {
            RiskManagement_Repository _RMCRITHAZARDMASREPO = new RiskManagement_Repository();
            return _RMCRITHAZARDMASREPO.GETRMCRITHAZARDMASREPO();
        }

        [Route("ADDRMCRITHAZARDMAS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE ADDRMCRITHAZARDMAS(ADD_RM_CRIT_HAZARD_MASTER _ADDRMCRITHAZARDMASTER)
        {
            RiskManagement_Repository __ADDRMCRITHAZARDMASREPO = new RiskManagement_Repository();
            return __ADDRMCRITHAZARDMASREPO.ADDRMCRITHAZARDMASREPO(_ADDRMCRITHAZARDMASTER);
        }

        [Route("UPDATERMCRITHAZARDMAS")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_RMCRITHAZARDMAS(ADD_RM_CRIT_HAZARD_MASTER _UPDATERMCRITHAZARDMASTER)
        {
            RiskManagement_Repository _UPDATERMCRITHAZARDMASREPO = new RiskManagement_Repository();
            return _UPDATERMCRITHAZARDMASREPO.ADDRMCRITHAZARDMASREPO(_UPDATERMCRITHAZARDMASTER);
        }

        [Route("GETEDITRMCRITHAZARDMAS")]
        //GET: api/UserDetails
        public ADD_RM_CRIT_HAZARD_MASTER GETEDITRMCRITHAZARDMAS(string CRIT_HAZARD_MAS_ID)
        {
            RiskManagement_Repository _EDITRMCRITHAZARDMASREPO = new RiskManagement_Repository();
            return _EDITRMCRITHAZARDMASREPO.GETEDITRMCRITHAZARDMASREPO(CRIT_HAZARD_MAS_ID);
        }

        [Route("DELETERMCRITHAZARDMAS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DELETERMCRITHAZARDMAS(string CRIT_HAZARD_MAS_ID)
        {
            RiskManagement_Repository _DELETERMCRITHAZARDMASREPO = new RiskManagement_Repository();
            return _DELETERMCRITHAZARDMASREPO.DELETERMCRITHAZARDMASREPO(CRIT_HAZARD_MAS_ID);
        }

        #endregion

        #region [Non Critical Hazard Master]

        [Route("GETRMNONCRITHAZMAS")]
        public IEnumerable<GET_RM_NON_CRIT_HAZ_MASTER> GETRMNONCRITHAZMAS()
        {
            RiskManagement_Repository _RMNONCRITHAZMASREPO = new RiskManagement_Repository();
            return _RMNONCRITHAZMASREPO.GETRMNONCRITHAZMASREPO();
        }

        [Route("ADDRMNONCRITHAZMAS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE ADDRMNONCRITHAZMAS(ADD_RM_NON_CRIT_HAZ_MASTER _ADDADDRMNONCRITHAZMASTER)
        {
            RiskManagement_Repository __ADDRMNONCRITHAZMASREPO = new RiskManagement_Repository();
            return __ADDRMNONCRITHAZMASREPO.ADDRMNONCRITHAZMASREPO(_ADDADDRMNONCRITHAZMASTER);
        }

        [Route("UPDATERMNONCRITHAZMAS")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_RMNONCRITHAZMAS(ADD_RM_NON_CRIT_HAZ_MASTER _UPDATERMNONCRITHAZMASTER)
        {
            RiskManagement_Repository _UPDATERMNONCRITHAZMASREPO = new RiskManagement_Repository();
            return _UPDATERMNONCRITHAZMASREPO.ADDRMNONCRITHAZMASREPO(_UPDATERMNONCRITHAZMASTER);
        }

        [Route("GETEDITRMNONCRITHAZMAS")]
        //GET: api/UserDetails
        public ADD_RM_NON_CRIT_HAZ_MASTER GETEDITRMNONCRITHAZMAS(string NON_CRIT_HAZ_MAS_ID)
        {
            RiskManagement_Repository _EDITRMNONCRITHAZMASREPO = new RiskManagement_Repository();
            return _EDITRMNONCRITHAZMASREPO.GETEDITRMNONCRITHAZMASREPO(NON_CRIT_HAZ_MAS_ID);
        }

        [Route("DELETERMNONCRITHAZMAS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DELETERMNONCRITHAZMAS(string NON_CRIT_HAZ_MAS_ID)
        {
            RiskManagement_Repository _DELETERRMNONCRITHAZMASREPO = new RiskManagement_Repository();
            return _DELETERRMNONCRITHAZMASREPO.DELETERMNONCRITHAZMASREPO(NON_CRIT_HAZ_MAS_ID);
        }

        #endregion

        #region [Non-Routine and Emergencies]

        [Route("GETRMNONROUTEMERGMAS")] 
        public IEnumerable<GET_RM_NON_ROUT_EMERG_MASTER> GETRMNONROUTEMERGMAS()
        {
            RiskManagement_Repository _RMNONROUTEMERGMASREPO = new RiskManagement_Repository();
            return _RMNONROUTEMERGMASREPO.GETRMNONROUTEMERGMASREPO();
        }

        [Route("ADDRMNONROUTEMERGMAS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE ADDRMNONROUTEMERGMAS(ADD_RM_NON_ROUT_EMERG_MASTER _ADDRMNONROUTEMERGMASTER)
        {
            RiskManagement_Repository __ADDRMNONROUTEMERGMASREPO = new RiskManagement_Repository();
            return __ADDRMNONROUTEMERGMASREPO.ADDRMNONROUTEMERGMASREPO(_ADDRMNONROUTEMERGMASTER);
        }

        [Route("UPDATERMNONROUTEMERGMAS")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_RMNONROUTEMERGMAS(ADD_RM_NON_ROUT_EMERG_MASTER _UPDATERMNONROUTEMERGMASTER)
        {
            RiskManagement_Repository _UPDATERMNONROUTEMERGMASREPO = new RiskManagement_Repository();
            return _UPDATERMNONROUTEMERGMASREPO.ADDRMNONROUTEMERGMASREPO(_UPDATERMNONROUTEMERGMASTER);
        }

        [Route("GETEDITRMNONROUTEMERGMAS")]
        //GET: api/UserDetails
        public ADD_RM_NON_ROUT_EMERG_MASTER GETEDITRMNONROUTEMERGMAS(string NON_ROUT_EMERG_ID)
        {
            RiskManagement_Repository _EDITRMNONROUTEMERGMASREPO = new RiskManagement_Repository();
            return _EDITRMNONROUTEMERGMASREPO.GETEDITRMNONROUTEMERGMASREPO(NON_ROUT_EMERG_ID);
        }

        [Route("DELETERMNONROUTEMERGMAS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DELETERMNONROUTEMERGMAS(string NON_ROUT_EMERG_ID)
        {
            RiskManagement_Repository _DELETERMNONROUTEMERGMASREPO = new RiskManagement_Repository();
            return _DELETERMNONROUTEMERGMASREPO.DELETERMNONROUTEMERGMASREPO(NON_ROUT_EMERG_ID);
        }

        #endregion

        #region [Existing control measures for identified hazard]

        [Route("GETRMEXISTINGCMIHMAS")]
        public IEnumerable<GET_RM_EXISTING_CMIH_MASTER> GETRMEXISTINGCMIHMAS()
        {
            RiskManagement_Repository _RMEXISTINGCMIHMASREPO = new RiskManagement_Repository();
            return _RMEXISTINGCMIHMASREPO.GETRMEXISTINGCMIHMASREPO();
        }

        [Route("ADDRMEXISTINGCMIHMAS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE ADDRMEXISTINGCMIHMAS(ADD_RM_EXISTING_CMIH_MASTER _ADDRMEXISTINGCMIHMASTER)
        {
            RiskManagement_Repository __ADDRMEXISTINGCMIHMASREPO = new RiskManagement_Repository();
            return __ADDRMEXISTINGCMIHMASREPO.ADDRMEXISTINGCMIHMASREPO(_ADDRMEXISTINGCMIHMASTER);
        }

        [Route("UPDATERMEXISTINGCMIHMAS")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_RMEXISTINGCMIHMAS(ADD_RM_EXISTING_CMIH_MASTER _UPDATERMEXISTINGCMIHMASTER)
        {
            RiskManagement_Repository _UPDATERMEXISTINGCMIHMASREPO = new RiskManagement_Repository();
            return _UPDATERMEXISTINGCMIHMASREPO.ADDRMEXISTINGCMIHMASREPO(_UPDATERMEXISTINGCMIHMASTER);
        }

        [Route("GETEDITRMEXISTINGCMIHMAS")]
        //GET: api/UserDetails
        public ADD_RM_EXISTING_CMIH_MASTER GETEDITRMEXISTINGCMIHMAS(string EXISTING_CMIH_MAS_ID)
        {
            RiskManagement_Repository _EDITRMEXISTINGCMIHMASREPO = new RiskManagement_Repository();
            return _EDITRMEXISTINGCMIHMASREPO.GETEDITRMEXISTINGCMIHMASREPO(EXISTING_CMIH_MAS_ID);
        }

        [Route("DELETERMEXISTINGCMIHMAS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DELETERMEXISTINGCMIHMAS(string EXISTING_CMIH_MAS_ID)
        {
            RiskManagement_Repository _DELETERMEXISTINGCMIHMASREPO = new RiskManagement_Repository();
            return _DELETERMEXISTINGCMIHMASREPO.DELETERMEXISTINGCMIHMASREPO(EXISTING_CMIH_MAS_ID);
        }

        #endregion

        #region [Additional Control Measures]

        [Route("GETADDTCONTMEAS")]
        public IEnumerable<GET_RM_ADD_CONT_MEAS> GETADDTCONTMEAS()
        {
            RiskManagement_Repository _GETADDTCONTMEASREPO = new RiskManagement_Repository();
            return _GETADDTCONTMEASREPO.GETADDTCONTMEASREPO();
        }

        [Route("ADDCONTMEAS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE ADDCONTMEAS(ADD_RM_ADD_CONT_MEAS _ADDCONTMEAS)
        {
            RiskManagement_Repository __ADDCONTMEASREPO = new RiskManagement_Repository();
            return __ADDCONTMEASREPO.ADDCONTMEASREPO(_ADDCONTMEAS);
        }

        [Route("UPDATEADDCONTMEAS")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_ADDCONTMEAS(ADD_RM_ADD_CONT_MEAS _UPDATEADDCONTMEAS)
        {
            RiskManagement_Repository _UPDATEADDCONTMEASREPO = new RiskManagement_Repository();
            return _UPDATEADDCONTMEASREPO.ADDCONTMEASREPO(_UPDATEADDCONTMEAS);
        }

        [Route("GETEDITADDCONTMEAS")]
        //GET: api/UserDetails
        public ADD_RM_ADD_CONT_MEAS GETEDITADDCONTMEAS(string ADD_CONT_MEAS_ID)
        {
            RiskManagement_Repository _EDITADDCONTMEASREPO = new RiskManagement_Repository();
            return _EDITADDCONTMEASREPO.GETEDITADDCONTMEASREPO(ADD_CONT_MEAS_ID);
        }

        [Route("DELETEADDCONTMEAS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DELETEADDCONTMEAS(string ADD_CONT_MEAS_ID)
        {
            RiskManagement_Repository _DELETEADDCONTMEASREPO = new RiskManagement_Repository();
            return _DELETEADDCONTMEASREPO.DELETEADDCONTMEASREPO(ADD_CONT_MEAS_ID);
        }

        #endregion

        #region [Opportunities and other opportunities]

        [Route("GETOPPORTUNITIES")]
        public IEnumerable<GET_RM_OPPORTUNITIES> GETOPPORTUNITIES()
        {
            RiskManagement_Repository _GETOPPORTUNITIESREPO = new RiskManagement_Repository();
            return _GETOPPORTUNITIESREPO.GETOPPORTUNITIESREPO();
        }

        [Route("ADDOPPORTUNITIES")]
        // GET: api/UserDetails
        public RETURN_MESSAGE ADDOPPORTUNITIES(ADD_RM_OPPORTUNITIES _ADDOPPORTUNITIES)
        {
            RiskManagement_Repository __ADDOPPORTUNITIESREPO = new RiskManagement_Repository();
            return __ADDOPPORTUNITIESREPO.ADDOPPORTUNITIESREPO(_ADDOPPORTUNITIES);
        }

        [Route("UPDATEOPPORTUNITIES")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_OPPORTUNITIES(ADD_RM_OPPORTUNITIES _UPDATEOPPORTUNITIES)
        {
            RiskManagement_Repository _UPDATEOPPORTUNITIESREPO = new RiskManagement_Repository();
            return _UPDATEOPPORTUNITIESREPO.ADDOPPORTUNITIESREPO(_UPDATEOPPORTUNITIES);
        }

        [Route("GETEDITOPPORTUNITIES")]
        //GET: api/UserDetails
        public ADD_RM_OPPORTUNITIES GETEDITOPPORTUNITIES(string OPPORTUNITIES_ID)
        {
            RiskManagement_Repository _EDITOPPORTUNITIESREPO = new RiskManagement_Repository();
            return _EDITOPPORTUNITIESREPO.GETEDITOPPORTUNITIESREPO(OPPORTUNITIES_ID);
        }

        [Route("DELETEOPPORTUNITIES")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DELETEOPPORTUNITIES(string OPPORTUNITIES_ID)
        {
            RiskManagement_Repository _DELETEOPPORTUNITIESREPO = new RiskManagement_Repository();
            return _DELETEOPPORTUNITIESREPO.DELETEOPPORTUNITIESREPO(OPPORTUNITIES_ID);
        }

        #endregion

        #region [ Risk Assessment Dropdown Select]

        [Route("GetHazardDescSelect")]
        //GET: api/UserDetails
        public IEnumerable<GET_RM_HAZARD_MASTER> GetHazardDescSelect(string HAZ_RISK_CAT_MAS_ID)
        {
            RiskManagement_Repository _GetHazardDescSelectRepo = new RiskManagement_Repository();
            return _GetHazardDescSelectRepo.GetHazardDescSelectRepo(HAZ_RISK_CAT_MAS_ID);
        }

        [Route("GetRisksOtherRisksSelect")]
        //GET: api/UserDetails
        public IEnumerable<GET_RM_RISKS_OTHER_RISKS> GetRisksOtherRisksSelect(string RISKS_HAZARD_MAS_ID)
        {
            RiskManagement_Repository _GetRisksOtherRisksSelectRepo = new RiskManagement_Repository();
            return _GetRisksOtherRisksSelectRepo.GetRisksOtherRisksSelectRepo(RISKS_HAZARD_MAS_ID);
        }

        [Route("GetPersonsGroupsSelect")]
        //GET: api/UserDetails
        public IEnumerable<GET_RM_PERSONS_GROUPS> GetPersonsGroupsSelect(string PG_HAZARD_MAS_ID)
        {
            RiskManagement_Repository _GetPersonsGroupsSelectRepo = new RiskManagement_Repository();
            return _GetPersonsGroupsSelectRepo.GetPersonsGroupsSelectRepo(PG_HAZARD_MAS_ID);
        }

        [Route("GetDetailsExistingControlsSelect")]
        //GET: api/UserDetails
        public IEnumerable<GET_RM_DETAILS_EXIST_CONT> GetDetailsExistingControlsSelect(string DEC_HAZARD_MAS_ID)
        {
            RiskManagement_Repository _GetDetailsExistingControlsSelectRepo = new RiskManagement_Repository();
            return _GetDetailsExistingControlsSelectRepo.GetDetailsExistingControlsSelectRepo(DEC_HAZARD_MAS_ID);
        }


        [Route("GetAddConMeasSelect")]
        //GET: api/UserDetails
        public IEnumerable<GET_RM_ADD_CONT_MEAS> GetAddConMeasSelect(string ACM_HAZARD_MAS_ID)
        {
            RiskManagement_Repository _GetAddConMeasSelectRepo = new RiskManagement_Repository();
            return _GetAddConMeasSelectRepo.GetAddConMeasSelectRepo(ACM_HAZARD_MAS_ID);
        }

        [Route("GetOpportunitiesSelect")]
        //GET: api/UserDetails
        public IEnumerable<GET_RM_OPPORTUNITIES> GetOpportunitiesSelect(string OPTY_HAZARD_MAS_ID)
        {
            RiskManagement_Repository _GetOpportunitiesSelectRepo = new RiskManagement_Repository();
            return _GetOpportunitiesSelectRepo.GetOpportunitiesSelectRepo(OPTY_HAZARD_MAS_ID);
        }

        #endregion
    }
}

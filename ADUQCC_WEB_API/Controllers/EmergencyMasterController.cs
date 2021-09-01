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
    [RoutePrefix("api/EmergencyMaster")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmergencyMasterController : ApiController
    {

        #region [ImmediateCause_UnsafeAct]
        [Route("GetEMRICActDetails")]
        public IEnumerable<GET_EMR_IC_ACT_DETAILS> GetEMRICActDetails()
        {
            EmergencyMaster_Repository _emricactdetrails = new EmergencyMaster_Repository();
            return _emricactdetrails.GetEMRICActDetails();
        }

        [Route("AddEMRICActDetails")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddEMRICActDetails(ADD_EMRICAct_MASTER _EMRICAct_MASTER)
        {
            EmergencyMaster_Repository _emricactdetrailsRepo = new EmergencyMaster_Repository();
            return _emricactdetrailsRepo.AddEMRICActMaster(_EMRICAct_MASTER);
        }

        [Route("GetEMRICActEdit")]
        //GET: api/UserDetails
        public ADD_EMRICAct_MASTER GetEMRICActEdit(string CAUSE_ID)
        {
            EmergencyMaster_Repository _emricacteditRepo = new EmergencyMaster_Repository();
            return _emricacteditRepo.GetEMRICActEdit(CAUSE_ID);
        }

        [Route("UpdateEMRICAct")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT(ADD_EMRICAct_MASTER _EMRICAct_MASTER)
        {
            EmergencyMaster_Repository _emricacteupdateRepo = new EmergencyMaster_Repository();
            return _emricacteupdateRepo.AddEMRICActMaster(_EMRICAct_MASTER);
        }

        [Route("DeleteEMRICAct")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteEMRICAct(string CAUSE_ID)
        {
            EmergencyMaster_Repository _emricactedeleteRepo = new EmergencyMaster_Repository();
            return _emricactedeleteRepo.DeleteEMRICAct(CAUSE_ID);
        }

        #endregion

        #region [ImmediateCause_UnsafeConditions]


        [Route("GetEMRICUCDetails")]
        public IEnumerable<GET_EMR_IC_UC_DETAILS> GetEMRICUCDetails()
        {
            EmergencyMaster_Repository _GetEMRICUCDetail = new EmergencyMaster_Repository();
            return _GetEMRICUCDetail.GetEMRICUCDetails();
        }

        [Route("AddEEMRICUC")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddEEMRICUC(ADD_EMR_IC_UC_MASTER _ADDEMRICUC)
        {
            EmergencyMaster_Repository __ADDEMRICUCRepo = new EmergencyMaster_Repository();
            return __ADDEMRICUCRepo.AddEEMRICUC(_ADDEMRICUC);
        }

        [Route("UpdateEMRICUC")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_UpdateEMRICUC(ADD_EMR_IC_UC_MASTER _EMRICUC_MASTER)
        {
            EmergencyMaster_Repository _emricuceupdateRepo = new EmergencyMaster_Repository();
            return _emricuceupdateRepo.AddEEMRICUC(_EMRICUC_MASTER);
        }

        [Route("GetEMRICUCEdit")]
        //GET: api/UserDetails
        public ADD_EMR_IC_UC_MASTER GetEMRICUCEdit(string IM_UNSAFE_ID)
        {
            EmergencyMaster_Repository _emricuceditRepo = new EmergencyMaster_Repository();
            return _emricuceditRepo.GetEMRICUCEdit(IM_UNSAFE_ID);
        }

        [Route("DeleteEMRICUC")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteEMRICUC(string IM_UNSAFE_ID)
        {
            EmergencyMaster_Repository _emricucedeleteRepo = new EmergencyMaster_Repository();
            return _emricucedeleteRepo.DeleteEMRICUC(IM_UNSAFE_ID);
        }

        #endregion

        #region [Root Causes (Personal factor)]


        [Route("GetEMRRCPFDetails")]
        public IEnumerable<GET_EMR_RC_PF_DETAILS> GetEMRRCPFDetails()
        {
            EmergencyMaster_Repository _GetEMRRCPFDetails = new EmergencyMaster_Repository();
            return _GetEMRRCPFDetails.GetEMRRCPFDetails();
        }

        [Route("AddEEMRRCPF")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddEEMRRCPF(ADD_EMR_RC_PF_MASTER _AddEEMRRCPF)
        {
            EmergencyMaster_Repository __AddEEMRRCPFRepo = new EmergencyMaster_Repository();
            return __AddEEMRRCPFRepo.AddEEMRRCPF(_AddEEMRRCPF);
        }

        [Route("UpdateEMRRCPF")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_UpdateEMRRCPF(ADD_EMR_RC_PF_MASTER _EMRRCPF_MASTER)
        {
            EmergencyMaster_Repository _emrrcpfupdateRepo = new EmergencyMaster_Repository();
            return _emrrcpfupdateRepo.AddEEMRRCPF(_EMRRCPF_MASTER);
        }

        [Route("GetEMRRCPFEdit")]
        //GET: api/UserDetails
        public ADD_EMR_RC_PF_MASTER GetEMRRCPFEdit(string ROOT_CAUSE_ID)
        {
            EmergencyMaster_Repository _emrrcpfeditRepo = new EmergencyMaster_Repository();
            return _emrrcpfeditRepo.GetEMRRCPFEdit(ROOT_CAUSE_ID);
        }

        [Route("DeleteEMRRCPF")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteEMRRCPF(string ROOT_CAUSE_ID)
        {
            EmergencyMaster_Repository _emrrcpfdeleteRepo = new EmergencyMaster_Repository();
            return _emrrcpfdeleteRepo.DeleteEMRRCPF(ROOT_CAUSE_ID);
        }

        #endregion

        #region [Root Causes (System factor)]


        [Route("GetEMRRCSFDetails")]
        public IEnumerable<GET_EMR_RC_SF_DETAILS> GetEMRRCSFDetails()
        {
            EmergencyMaster_Repository _GetEMRRCSFDetails = new EmergencyMaster_Repository();
            return _GetEMRRCSFDetails.GetEMRRCSFDetails();
        }

        [Route("AddEEMRRCSF")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddEEMRRCSF(ADD_EMR_RC_SF_MASTER _AddEEMRRCSF)
        {
            EmergencyMaster_Repository __AddEEMRRCSFRepo = new EmergencyMaster_Repository();
            return __AddEEMRRCSFRepo.AddEEMRRCSF(_AddEEMRRCSF);
        }

        [Route("UpdateEMRRCSF")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_UpdateEMRRCSF(ADD_EMR_RC_SF_MASTER _EMRRCSF_MASTER)
        {
            EmergencyMaster_Repository _emrrcsfupdateRepo = new EmergencyMaster_Repository();
            return _emrrcsfupdateRepo.AddEEMRRCSF(_EMRRCSF_MASTER);
        }

        [Route("GetEMRRCSFEdit")]
        //GET: api/UserDetails
        public ADD_EMR_RC_SF_MASTER GetEMRRCSFEdit(string RC_SF_ID)
        {
            EmergencyMaster_Repository _emrrcsfeditRepo = new EmergencyMaster_Repository();
            return _emrrcsfeditRepo.GetEMRRCSFEdit(RC_SF_ID);
        }

        [Route("DeleteEMRRCSF")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteEMRRCSF(string RC_SF_ID)
        {
            EmergencyMaster_Repository _emrrcsfdeleteRepo = new EmergencyMaster_Repository();
            return _emrrcsfdeleteRepo.DeleteEMRRCSF(RC_SF_ID);
        }

        #endregion

        #region [Nature of Injury / Illness]


        [Route("GetEMRNIIDetails")]
        public IEnumerable<GET_EMR_NATURE_INJURY_DETAILS> GetEMRNIIDetails()
        {
            EmergencyMaster_Repository _GetEMRNIIDetails = new EmergencyMaster_Repository();
            return _GetEMRNIIDetails.GetEMRNIIDetails();
        }

        [Route("AddEMRNII")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddEMRNII(ADD_EMR_NATURE_INJURY_MASTER _AddEMRNII)
        {
            EmergencyMaster_Repository __AddEMRNIIRepo = new EmergencyMaster_Repository();
            return __AddEMRNIIRepo.AddEMRNII(_AddEMRNII);
        }

        [Route("UpdateEMRNII")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_UpdateEMRNII(ADD_EMR_NATURE_INJURY_MASTER _EMRNII_MASTER)
        {
            EmergencyMaster_Repository _emrNIIupdateRepo = new EmergencyMaster_Repository();
            return _emrNIIupdateRepo.AddEMRNII(_EMRNII_MASTER);
        }

        [Route("GetEMRNIIEdit")]
        //GET: api/UserDetails
        public ADD_EMR_NATURE_INJURY_MASTER GetEMRNIIEdit(string NATURE_INJURY_ID)
        {
            EmergencyMaster_Repository _emrNIIeditRepo = new EmergencyMaster_Repository();
            return _emrNIIeditRepo.GetEMRNIIEdit(NATURE_INJURY_ID);
        }

        [Route("DeleteEMRNII")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteEMRNII(string NATURE_INJURY_ID)
        {
            EmergencyMaster_Repository _emrNIIdeleteRepo = new EmergencyMaster_Repository();
            return _emrNIIdeleteRepo.DeleteEMRNII(NATURE_INJURY_ID);
        }

        #endregion

        #region [Mechanism of Injury / Illness]


        [Route("GetEMRMIIDetails")]
        public IEnumerable<GET_EMR_MECH_INJURY_DETAILS> GetEMRMIIDetails()
        {
            EmergencyMaster_Repository _GetEMRMIIDetails = new EmergencyMaster_Repository();
            return _GetEMRMIIDetails.GetEMRMIIDetails();
        }

        [Route("AddEMRMII")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddEMRMII(ADD_EMR_MECH_INJURY_MASTER _AddEMRMII)
        {
            EmergencyMaster_Repository __AddEMRMIIRepo = new EmergencyMaster_Repository();
            return __AddEMRMIIRepo.AddEMRMII(_AddEMRMII);
        }

        [Route("UpdateEMRMII")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_UpdateEMRMII(ADD_EMR_MECH_INJURY_MASTER _EMRMII_MASTER)
        {
            EmergencyMaster_Repository _emrMIIupdateRepo = new EmergencyMaster_Repository();
            return _emrMIIupdateRepo.AddEMRMII(_EMRMII_MASTER);
        }

        [Route("GetEMRMIIEdit")]
        //GET: api/UserDetails
        public ADD_EMR_MECH_INJURY_MASTER GetEMRMIIEdit(string MECH_INJURY_ID)
        {
            EmergencyMaster_Repository _emrMIIeditRepo = new EmergencyMaster_Repository();
            return _emrMIIeditRepo.GetEMRMIIEdit(MECH_INJURY_ID);
        }

        [Route("DeleteEMRMII")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteEMRMII(string MECH_INJURY_ID)
        {
            EmergencyMaster_Repository _emrMIIdeleteRepo = new EmergencyMaster_Repository();
            return _emrMIIdeleteRepo.DeleteEMRMII(MECH_INJURY_ID);
        }

        #endregion

        #region [Agency / Source of Injury / Illness]


        [Route("GetEMRAIIDetails")]
        public IEnumerable<GET_EMR_AGENCY_INJURY_DETAILS> GetEMRAIIDetails()
        {
            EmergencyMaster_Repository _GetEMRAIIDetails = new EmergencyMaster_Repository();
            return _GetEMRAIIDetails.GetEMRAIIDetails();
        }

        [Route("AddEMRAII")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddEMRAII(ADD_EMR_AGENCY_INJURY_MASTER _AddEMRAII)
        {
            EmergencyMaster_Repository __AddEMRAIIRepo = new EmergencyMaster_Repository();
            return __AddEMRAIIRepo.AddEMRAII(_AddEMRAII);
        }

        [Route("UpdateEMRAII")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_UpdateEMRAII(ADD_EMR_AGENCY_INJURY_MASTER _EMRAII_MASTER)
        {
            EmergencyMaster_Repository _emrAIIupdateRepo = new EmergencyMaster_Repository();
            return _emrAIIupdateRepo.AddEMRAII(_EMRAII_MASTER);
        }

        [Route("GetEMRAIIEdit")]
        //GET: api/UserDetails
        public ADD_EMR_AGENCY_INJURY_MASTER GetEMRAIIEdit(string AGENCY_INJURY_ID)
        {
            EmergencyMaster_Repository _emrAIIeditRepo = new EmergencyMaster_Repository();
            return _emrAIIeditRepo.GetEMRAIIEdit(AGENCY_INJURY_ID);
        }

        [Route("DeleteEMRAII")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteEMRAII(string AGENCY_INJURY_ID)
        {
            EmergencyMaster_Repository _emrAIIdeleteRepo = new EmergencyMaster_Repository();
            return _emrAIIdeleteRepo.DeleteEMRAII(AGENCY_INJURY_ID);
        }

        #endregion

        #region [ Body Location ]

        #region [Body Location Category Master]


        [Route("GetemrBODYLOCCATdetails")]
        public IEnumerable<GET_EMR_BODY_LOC_CAT_DETAILS> GetemrBODYLOCCATdetails()
        {
            EmergencyMaster_Repository _GetemrBODYLOCCATdetails = new EmergencyMaster_Repository();
            return _GetemrBODYLOCCATdetails.GetemrBODYLOCCATdetails();
        }

        [Route("AddemrBODYLOCCAT")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddemrBODYLOCCAT(ADD_EMR_BODY_LOC_CAT_MASTER _AddEMRBODYLOCCAT)
        {
            EmergencyMaster_Repository __AddemrBODYLOCCATrepo = new EmergencyMaster_Repository();
            return __AddemrBODYLOCCATrepo.AddemrBODYLOCCAT(_AddEMRBODYLOCCAT);
        }

        [Route("UpdateemrBODYLOCCAT")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_UpdateemrBODYLOCCAT(ADD_EMR_BODY_LOC_CAT_MASTER _emrBODYLOCCAT_MASTER)
        {
            EmergencyMaster_Repository _emrBODYLOCCATupdateRepo = new EmergencyMaster_Repository();
            return _emrBODYLOCCATupdateRepo.AddemrBODYLOCCAT(_emrBODYLOCCAT_MASTER);
        }

        [Route("GetemrBODYLOCCATedit")]
        //GET: api/UserDetails
        public ADD_EMR_BODY_LOC_CAT_MASTER GetemrBODYLOCCATedit(string BODY_LOC_CAT_ID)
        {
            EmergencyMaster_Repository _emrBODYLOCCATeditRepo = new EmergencyMaster_Repository();
            return _emrBODYLOCCATeditRepo.GetemrBODYLOCCATedit(BODY_LOC_CAT_ID);
        }

        [Route("DeleteemrBODYLOCCAT")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteemrBODYLOCCAT(string BODY_LOC_CAT_ID)
        {
            EmergencyMaster_Repository _emrBODYLOCCATdeleterepo = new EmergencyMaster_Repository();
            return _emrBODYLOCCATdeleterepo.DeleteemrBODYLOCCAT(BODY_LOC_CAT_ID);
        }


        #endregion

        #region [Body Location]


        [Route("GetEMRBodyLocDetails")]
        public IEnumerable<GET_EMR_BODY_LOC_DETAILS> GetEMRBodyLocDetails()
        {
            EmergencyMaster_Repository _GetEMRBodyLocDetails = new EmergencyMaster_Repository();
            return _GetEMRBodyLocDetails.GetEMRBodyLocDetails();
        }

        [Route("AddEMRBodyLoc")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddEMRBodyLoc(ADD_EMR_BODY_LOC_MASTER _AddEMRBodyLoc)
        {
            EmergencyMaster_Repository __AddEMRBodyLocRepo = new EmergencyMaster_Repository();
            return __AddEMRBodyLocRepo.AddEMRBodyLoc(_AddEMRBodyLoc);
        }

        [Route("UpdateEMRBodyLoc")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_UpdateEMRBodyLoc(ADD_EMR_BODY_LOC_MASTER _EMRBodyLoc_MASTER)
        {
            EmergencyMaster_Repository _emrBodyLocupdateRepo = new EmergencyMaster_Repository();
            return _emrBodyLocupdateRepo.AddEMRBodyLoc(_EMRBodyLoc_MASTER);
        }

        [Route("GetEMRBodyLocEdit")]
        //GET: api/UserDetails
        public ADD_EMR_BODY_LOC_MASTER GetEMRBodyLocEdit(string BODY_LOC_ID)
        {
            EmergencyMaster_Repository _emrBodyLoceditRepo = new EmergencyMaster_Repository();
            return _emrBodyLoceditRepo.GetEMRBodyLocEdit(BODY_LOC_ID);
        }

        [Route("DeleteEMRBodyLoc")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteEMRBodyLoc(string BODY_LOC_ID)
        {
            EmergencyMaster_Repository _emrBodyLocdeleteRepo = new EmergencyMaster_Repository();
            return _emrBodyLocdeleteRepo.DeleteEMRBodyLoc(BODY_LOC_ID);
        }

        [Route("GET_BODY_LOCATION_SUBCAT")]
        public IEnumerable<GET_EMR_BODY_LOC_DETAILS> GET_BODY_LOCATION_SUBCAT(string CAT_ID)
        {
            EmergencyMaster_Repository _inccatRepo = new EmergencyMaster_Repository();
            return _inccatRepo.GET_BODY_LOCATION_SUBCAT(CAT_ID);
        }

        #endregion

        #endregion

        #region [Incident Cause Analysis]


        [Route("GetemrINCDTCAdetails")]
        public IEnumerable<GET_EMR_INCDT_CA_DETAILS> GetemrINCDTCAdetails()
        {
            EmergencyMaster_Repository _GetemrINCDTCAdetails = new EmergencyMaster_Repository();
            return _GetemrINCDTCAdetails.GetemrINCDTCAdetails();
        }

        [Route("AddemrINCDTCA")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddemrINCDTCA(ADD_EMR_INCDT_CA_MASTER _AddEMRINCDTCA)
        {
            EmergencyMaster_Repository __addemrINCDTCArepo = new EmergencyMaster_Repository();
            return __addemrINCDTCArepo.AddemrINCDTCA(_AddEMRINCDTCA);
        }

        [Route("UpdateemrINCDTCA")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_UpdateemrINCDTCA(ADD_EMR_INCDT_CA_MASTER _EMRINCDTCA_MASTER)
        {
            EmergencyMaster_Repository _emrINCDTCAupdaterepo = new EmergencyMaster_Repository();
            return _emrINCDTCAupdaterepo.AddemrINCDTCA(_EMRINCDTCA_MASTER);
        }

        [Route("GetemrINCDTCAedit")]
        //GET: api/UserDetails
        public ADD_EMR_INCDT_CA_MASTER GetemrINCDTCAedit(string INCDT_CAS_ID)
        {
            EmergencyMaster_Repository _emrINCDTCAeditrepo = new EmergencyMaster_Repository();
            return _emrINCDTCAeditrepo.GetemrINCDTCAedit(INCDT_CAS_ID);
        }

        [Route("DeleteemrINCDTCA")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteemrINCDT(string INCDT_CAS_ID)
        {
            EmergencyMaster_Repository _emrINCDTCAdeleterepo = new EmergencyMaster_Repository();
            return _emrINCDTCAdeleterepo.DeleteemrINCDT(INCDT_CAS_ID);
        }

        #endregion

        #region [Risk Assessment Master]


        [Route("GetemrRISKASSMASTERdetails")]
        public IEnumerable<GET_EMR_RISK_ASS_MASTER_DETAILS> GetemrRISKASSMASTERdetails()
        {
            EmergencyMaster_Repository _GetemrRISKASSMASTERdetails = new EmergencyMaster_Repository();
            return _GetemrRISKASSMASTERdetails.GetemrRISKASSMASTERdetails();
        }

        [Route("AddemrRISKASSMASTER")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddemrRISKASSMASTER(ADD_EMR_RISK_ASS_MASTER_MASTER _AddEMRRISKASSMASTER)
        {
            EmergencyMaster_Repository __AddemrRISKASSMASTERrepo = new EmergencyMaster_Repository();
            return __AddemrRISKASSMASTERrepo.AddEMRRISKASSMASTER(_AddEMRRISKASSMASTER);
        }

        [Route("UpdateemrRISKASSMASTER")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_UpdateemrRISKASSMASTER(ADD_EMR_RISK_ASS_MASTER_MASTER _emrRISKASSMASTER_MASTER)
        {
            EmergencyMaster_Repository _emrRISKASSMASTERupdateRepo = new EmergencyMaster_Repository();
            return _emrRISKASSMASTERupdateRepo.AddEMRRISKASSMASTER(_emrRISKASSMASTER_MASTER);
        }

        [Route("GetemrRISKASSMASTERedit")]
        //GET: api/UserDetails
        public ADD_EMR_RISK_ASS_MASTER_MASTER GetemrRISKASSMASTERedit(string RISK_ASS_MASTER_ID)
        {
            EmergencyMaster_Repository _emrRISKASSMASTEReditRepo = new EmergencyMaster_Repository();
            return _emrRISKASSMASTEReditRepo.GetemrRISKASSMASTERedit(RISK_ASS_MASTER_ID);
        }

        [Route("DeleteemrRISKASSMASTER")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteemrRISKASSMASTER(string RISK_ASS_MASTER_ID)
        {
            EmergencyMaster_Repository _emrRISKASSMASTERdeleterepo = new EmergencyMaster_Repository();
            return _emrRISKASSMASTERdeleterepo.DeleteemrRISKASSMASTER(RISK_ASS_MASTER_ID);
        }

        #endregion

        #region [Risk Assessment]


        [Route("GetemrRISKASSdetails")]
        public IEnumerable<GET_EMR_RISK_ASSESSMENT_DETAILS> GetemrRISKASSdetails()
        {
            EmergencyMaster_Repository _GetemrRISKASSdetails = new EmergencyMaster_Repository();
            return _GetemrRISKASSdetails.GetemrRISKASSdetails();
        }

        [Route("AddemrRISKASS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddemrRISKASS(ADD_EMR_RISK_ASSESSMENT _AddEMRINCDTCA)
        {
            EmergencyMaster_Repository __addemrRISKASSrepo = new EmergencyMaster_Repository();
            return __addemrRISKASSrepo.AddemrRISKASS(_AddEMRINCDTCA);
        }

        [Route("UpdateemrRISKASS")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT_UpdateemrRISKASS(ADD_EMR_RISK_ASSESSMENT _EMRRISKASS_MASTER)
        {
            EmergencyMaster_Repository _emrRISKASSupdaterepo = new EmergencyMaster_Repository();
            return _emrRISKASSupdaterepo.AddemrRISKASS(_EMRRISKASS_MASTER);
        }

        [Route("GetemrRISKASSedit")]
        //GET: api/UserDetails
        public ADD_EMR_RISK_ASSESSMENT GetemrRISKASSedit(string RISK_ASS_ID)
        {
            EmergencyMaster_Repository _emrRISKASSeditrepo = new EmergencyMaster_Repository();
            return _emrRISKASSeditrepo.GetemrRISKASSedit(RISK_ASS_ID);
        }

        [Route("DeleteemrRISKASS")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteemrRISKASS(string RISK_ASS_ID)
        {
            EmergencyMaster_Repository _emrRISKASSdeleterepo = new EmergencyMaster_Repository();
            return _emrRISKASSdeleterepo.DeleteemrRISKASS(RISK_ASS_ID);
        }

        #endregion

        #region [INCCATEGORY_MASTER]
        [Route("GetIncidentCategory")]
        // GET: api/Masters
        public IEnumerable<GET_INCIDENT_CATEGORY_DETAILS> GetIncidentCategory()
        {
            EmergencyMaster_Repository _inccatRepo = new EmergencyMaster_Repository();
            return _inccatRepo.GetIncidentCategory();
        }

        [Route("AddIncidentCategory")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddIncidentCategory(IncidentCategoryModel _INCCAT_MASTER)
        {
            EmergencyMaster_Repository _inccatRepo = new EmergencyMaster_Repository();
            return _inccatRepo.AddIncidentCategory(_INCCAT_MASTER);
        }

        [Route("DeleteIncidentCategory")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteIncidentCategory(string INCCATID)
        {
            EmergencyMaster_Repository _inccatRepo = new EmergencyMaster_Repository();
            return _inccatRepo.DeleteIncidentCategory(INCCATID);
        }

        [Route("EditIncidentCategory")]
        //GET: api/UserDetails
        public IncidentCategoryModel GetIncidentCategoryEdit(string INCCATID)
        {
            EmergencyMaster_Repository _inccatRepo = new EmergencyMaster_Repository();
            return _inccatRepo.GetIncidentCategoryEdit(INCCATID);
        }

        [Route("UpdateIncidentCategory")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUTIncidentCategory(IncidentCategoryModel _INCCAT_MASTER)
        {
            EmergencyMaster_Repository _inccatRepo = new EmergencyMaster_Repository();
            return _inccatRepo.AddIncidentCategory(_INCCAT_MASTER);
        }


        #endregion

        #region [INCIDENTDETAILS]
        [Route("GetIncident")]
        // GET: api/UserDetails
        public IEnumerable<GET_INCIDENT_DETAILS> GetIncident()
        {
            EmergencyMaster_Repository _incRepo = new EmergencyMaster_Repository();
            return _incRepo.GetIncident();
        }

        [Route("AddIncident")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddIncident(IncidentModel _INC_DETAILS)
        {
            EmergencyMaster_Repository _incRepo = new EmergencyMaster_Repository();
            return _incRepo.AddIncident(_INC_DETAILS);
        }

        [Route("DeleteIncident")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteIncident(string INCID)
        {
            EmergencyMaster_Repository _incRepo = new EmergencyMaster_Repository();
            return _incRepo.DeleteIncident(INCID);
        }

        [Route("GetIncidentEdit")]
        //GET: api/UserDetails
        public IncidentModel GetIncidentEdit(string INCID)
        {
            EmergencyMaster_Repository _incRepo = new EmergencyMaster_Repository();
            return _incRepo.EditIncident(INCID);
        }

        [Route("UpdateIncident")]
        //GET: api/UserDetails
        public RETURN_MESSAGE PUT(IncidentModel _INC_DETAILS)
        {
            EmergencyMaster_Repository _incRepo = new EmergencyMaster_Repository();
            return _incRepo.AddIncident(_INC_DETAILS);
        }

        [Route("AddPhotoUpload")]
        // GET: api/UserDetails
        public RETURN_MESSAGE AddPhoto_Upload(List<UPLOAD_PHOTO_LIST> _UPLOAD_PHOTO)
        {
            EmergencyMaster_Repository _incRepo = new EmergencyMaster_Repository();
            return _incRepo.AddPhotoUpload(_UPLOAD_PHOTO);
        }

        #endregion

        #region [INSERT_INVESTIGATION]

        [Route("ADD_INVESTIGATION")]
        // GET: api/UserDetails
        public RETURN_MESSAGE ADD_INVESTIGATION(INVESTCATION_DETAILS _INVESTIGATION_DETAILS)
        {
            EmergencyMaster_Repository _incRepo = new EmergencyMaster_Repository();
            return _incRepo.ADD_INVESTIGATION(_INVESTIGATION_DETAILS);
        }
        #endregion

    }
}

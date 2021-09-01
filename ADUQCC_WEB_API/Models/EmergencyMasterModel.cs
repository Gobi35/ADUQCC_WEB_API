using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADUQCC_WEB_API.Models
{
    public class EmergencyMasterModel
    {
    }

    #region [ImmediateCause_UnsafeAct]
    public class GET_EMR_IC_ACT_DETAILS
    {
        public string CAUSE_ID { get; set; }
        public string CAUSENAME { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }


    }

    public class ADD_EMRICAct_MASTER
    {
        public string CAUSE_ID { get; set; }
        public string CAUSENAME { get; set; }
        public string CAUSE_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [ImmediateCause_UnsafeConditions]

    public class GET_EMR_IC_UC_DETAILS
    {
        public string IM_UNSAFE_ID { get; set; }
        public string IM_UNSAFENAME { get; set; }
        public string IM_UNSAFE_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }


    }

    public class ADD_EMR_IC_UC_MASTER
    {
        public string IM_UNSAFE_ID { get; set; }
        public string IM_UNSAFENAME { get; set; }
        public string IM_UNSAFE_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Root Causes (Personal factor)]

    public class GET_EMR_RC_PF_DETAILS
    {
        public string ROOT_CAUSE_ID { get; set; }
        public string ROOT_CAUSE_NAME { get; set; }
        public string ROOT_CAUSE_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }


    }

    public class ADD_EMR_RC_PF_MASTER
    {
        public string ROOT_CAUSE_ID { get; set; }
        public string ROOT_CAUSE_NAME { get; set; }
        public string ROOT_CAUSE_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Root Causes (System factor)]

    public class GET_EMR_RC_SF_DETAILS
    {
        public string RC_SF_ID { get; set; }
        public string RC_SF_NAME { get; set; }
        public string RC_SF_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }


    }

    public class ADD_EMR_RC_SF_MASTER
    {
        public string RC_SF_ID { get; set; }
        public string RC_SF_NAME { get; set; }
        public string RC_SF_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Nature of Injury / Illness]

    public class GET_EMR_NATURE_INJURY_DETAILS
    {
        public string NATURE_INJURY_ID { get; set; }
        public string NATURE_INJURY_NAME { get; set; }
        public string NATURE_INJURY_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }


    }

    public class ADD_EMR_NATURE_INJURY_MASTER
    {
        public string NATURE_INJURY_ID { get; set; }
        public string NATURE_INJURY_NAME { get; set; }
        public string NATURE_INJURY_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Mechanism of Injury / Illness]

    public class GET_EMR_MECH_INJURY_DETAILS
    {
        public string MECH_INJURY_ID { get; set; }
        public string MECH_INJURY_NAME { get; set; }
        public string MECH_INJURY_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }


    }

    public class ADD_EMR_MECH_INJURY_MASTER
    {
        public string MECH_INJURY_ID { get; set; }
        public string MECH_INJURY_NAME { get; set; }
        public string MECH_INJURY_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Agency / Source of Injury / Illness]

    public class GET_EMR_AGENCY_INJURY_DETAILS
    {
        public string AGENCY_INJURY_ID { get; set; }
        public string AGENCY_INJURY_NAME { get; set; }
        public string AGENCY_INJURY_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }


    }

    public class ADD_EMR_AGENCY_INJURY_MASTER
    {
        public string AGENCY_INJURY_ID { get; set; }
        public string AGENCY_INJURY_NAME { get; set; }
        public string AGENCY_INJURY_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [ Body Location ]

    #region [Body Location Category Master]

    public class GET_EMR_BODY_LOC_CAT_DETAILS
    {
        public string BODY_LOC_CAT_ID { get; set; }
        public string BODY_LOC_CAT_NAME { get; set; }
        public string BODY_LOC_CAT_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }


    }

    public class ADD_EMR_BODY_LOC_CAT_MASTER
    {
        public string BODY_LOC_CAT_ID { get; set; }
        public string BODY_LOC_CAT_NAME { get; set; }
        public string BODY_LOC_CAT_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Body Location]

    public class GET_EMR_BODY_LOC_DETAILS
    {
        public string BODY_LOC_ID { get; set; }

        public string BODY_LOC_CAT_ID { get; set; }
        public string CAT_NAME { get; set; }
        public string CAT_NAME_AR { get; set; }
        public string SUB_CAT_NAME { get; set; }
        public string SUB_CAT_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }


    }

    public class ADD_EMR_BODY_LOC_MASTER
    {
        public string BODY_LOC_ID { get; set; }

        public string BODY_LOC_CAT_ID { get; set; }
        public string CAT_NAME { get; set; }
        public string CAT_NAME_AR { get; set; }
        public string SUB_CAT_NAME { get; set; }
        public string SUB_CAT_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #endregion

    #region [Incident Cause Analysis]

    public class GET_EMR_INCDT_CA_DETAILS
    {
        public string INCDT_CAS_ID { get; set; }
        public string INCDT_CAS_NAME { get; set; }
        public string INCDT_CAS_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }


    }

    public class ADD_EMR_INCDT_CA_MASTER
    {
        public string INCDT_CAS_ID { get; set; }
        public string INCDT_CAS_NAME { get; set; }
        public string INCDT_CAS_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Risk Assessment Master]

    public class GET_EMR_RISK_ASS_MASTER_DETAILS
    {
        public string RISK_ASS_MASTER_ID { get; set; }
        public string RISK_ASS_MASTER_NAME { get; set; }
        public string RISK_ASS_MASTER_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }


    }

    public class ADD_EMR_RISK_ASS_MASTER_MASTER
    {
        public string RISK_ASS_MASTER_ID { get; set; }
        public string RISK_ASS_MASTER_NAME { get; set; }
        public string RISK_ASS_MASTER_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Risk Assessment]

    public class GET_EMR_RISK_ASSESSMENT_DETAILS
    {
        public string RISK_ASS_ID { get; set; }
        public string RISK_ASS_MASTER_ID { get; set; }
        public string RISK_ASS_MASTER_NAME { get; set; }
        public string RISK_ASS_POSSIBILITY { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }


    }

    public class ADD_EMR_RISK_ASSESSMENT
    {
        public string RISK_ASS_ID { get; set; }
        public string RISK_ASS_MASTER_ID { get; set; }
        public string RISK_ASS_POSSIBILITY { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }
    }

    #endregion

    #region [INCIDENTDETAILS]
    public class IncidentModel
    {
        public string INC_ID { get; set; }
        public string INC_CATEGORY { get; set; }
        public string INC_DATE_TIME { get; set; }
        public string INC_NOTIFY_BY { get; set; }
        public string INC_DEPART_ID { get; set; }
        public string INC_LOC_ID { get; set; }
        public string INC_SEC_ID { get; set; }
        public string INC_SEC_LAB_ID { get; set; }
        public string INC_BUIL_ID { get; set; }
        public string IS_PERSON_INVOLVED { get; set; }
        public string IS_FATALITY { get; set; }
        public string DESCRIPTION { get; set; }
        public string INC_TYPE { get; set; }
        public string REPORTED_BY { get; set; }
        public string CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string INC_STATUS { get; set; }
    }

    public class GET_INCIDENT_DETAILS
    {
        public string INC_ID { get; set; }
        public string LOC_NAME { get; set; }
        public string LOC_NAME_AR { get; set; }
        public string INC_CAT_NAME { get; set; }
        public string INC_CAT_NAME_AR { get; set; }

    }
    #endregion

    #region [INCIDENT_CATEGORY_MASTER]
    public class IncidentCategoryModel
    {
        public long INC_CAT_ID { get; set; }
        public string INC_CAT_NAME { get; set; }
        public string INC_CAT_NAME_AR { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public bool STATUS { get; set; }
        public string MESSAGE { get; set; }
        public string STATUS_CODE { get; set; }
    }

    public class GET_INCIDENT_CATEGORY_DETAILS
    {
        public long INC_CAT_ID { get; set; }
        public string INC_CAT_NAME { get; set; }
        public string INC_CAT_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
    }
    #endregion

    #region [PHOTO_UPLOAD]

    public class UPLOAD_PHOTO
    {
        public List<UPLOAD_PHOTO_LIST> UPLOAD_PHOTO_LIST { get; set; }
    }

    public class UPLOAD_PHOTO_LIST
    {
        public long INC_PHOTO_ID { get; set; }
        public string INC_ID { get; set; }
        public string INC_PHOTO_NAME { get; set; }
        public string INC_PHOTO_PATH { get; set; }
        public string INC_PHOTO_FILE_SIZE { get; set; }
        public string INC_PHOTO_FILE_TYPE { get; set; }
        public string INC_PHOTO_STATUS { get; set; }
        public string CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
    }


    #endregion

    #region [INVESTIGATION FORM]
    public class INVESTCATION_DETAILS
    {
        public List<INVE_IM_CASUE_ACT> INVE_IM_CASUE_ACT { get; set; }
        public List<INVE_IM_CASUE_UNC> INVE_IM_CASUE_UNC { get; set; }
        public List<INVE_IM_ROOT_PF> INVE_IM_ROOT_PF { get; set; }
        public List<INVE_IM_ROOT_SF> INVE_IM_ROOT_SF { get; set; }
        public List<INVE_NATURE_OF_INJURY> INVE_NATURE_OF_INJURY { get; set; }
        public List<INVE_MECHANISM_OF_INJURY> INVE_MECHANISM_OF_INJURY { get; set; }
        public List<INVE_SOURCE_OF_INJURY> INVE_SOURCE_OF_INJURY { get; set; }
        public List<INVE_BODY_LOC_CASUE> INVE_BODY_LOC_CASUE { get; set; }
        public List<ACTION_TAKEN_IMMEDIATELY> ACTION_TAKEN_IMMEDIATELY { get; set; }
        public List<INCIDENT_ROOT_CAUSE> INCIDENT_ROOT_CAUSE { get; set; }
        public List<CORRECTIVE_ACTION> CORRECTIVE_ACTION { get; set; }
        public List<INCIDENT_COST_ANALYSIS> INCIDENT_COST_ANALYSIS { get; set; }
        public List<INJURED_PERSONAL_DETAILS> INJURED_PERSONAL_DETAILS { get; set; }
        public List<RISK_ASSESSMENT_DETAILS> RISK_ASSESSMENT_DETAILS { get; set; }
        public List<DECLARATION_INJURED_PERSON> DECLARATION_INJURED_PERSON { get; set; }
    }
    public class INVE_IM_CASUE_ACT
    {
        public string INC_ID { get; set; }
        public string INVE_IM_CAUSE_ID { get; set; }
        public string INVE_OTHER_NAME { get; set; }
    }

    public class INVE_IM_CASUE_UNC
    {
        public string INC_ID { get; set; }
        public string INVE_IM_CAUSE_UNC_ID { get; set; }
        public string INVE_OTHER_NAME { get; set; }
    }

    public class INVE_IM_ROOT_PF
    {
        public string INC_ID { get; set; }
        public string INVE_IM_ROOT_PF_ID { get; set; }
        public string INVE_OTHER_NAME { get; set; }
    }

    public class INVE_IM_ROOT_SF
    {
        public string INC_ID { get; set; }
        public string INVE_IM_ROOT_SF_ID { get; set; }
        public string INVE_OTHER_NAME { get; set; }
    }

    public class INVE_NATURE_OF_INJURY
    {
        public string INC_ID { get; set; }
        public string NATURE_INJURY_NAME_ID { get; set; }
        public string INVE_OTHER_NAME { get; set; }
    }

    public class INVE_MECHANISM_OF_INJURY
    {
        public string INC_ID { get; set; }
        public string MECH_INJURY_NAME_ID { get; set; }
        public string INVE_OTHER_NAME { get; set; }
    }

    public class INVE_SOURCE_OF_INJURY
    {
        public string INC_ID { get; set; }
        public string SOURCE_INJURY_NAME_ID { get; set; }
        public string INVE_OTHER_NAME { get; set; }
    }

    public class INVE_BODY_LOC_CASUE
    {
        public string INC_ID { get; set; }
        public string INVE_IM_BODY_CAT_ID { get; set; }
        public string INVE_IM_SUB_CAT_ID { get; set; }
        public string INVE_OTHER_NAME { get; set; }
    }

    public class ACTION_TAKEN_IMMEDIATELY
    {
        public string INC_ID { get; set; }
        public string ACTION_NAME { get; set; }
        public string RESPONSIBILITY_ID { get; set; }
        public string DATE { get; set; }
    }

    public class INCIDENT_ROOT_CAUSE
    {
        public string INC_ID { get; set; }
        public string ROOT_NAME { get; set; }
    }

    public class CORRECTIVE_ACTION
    {
        public string INC_ID { get; set; }
        public string S_NO { get; set; }
        public string ACTION { get; set; }
        public string PERSON_RESPONSIBLE { get; set; }
        public string TARGET_DATE { get; set; }
    }

    public class INCIDENT_COST_ANALYSIS
    {
        public string INC_ID { get; set; }
        public string INC_COST_ID { get; set; }
        public string INC_COST_AMT { get; set; }
    }

    public class INJURED_PERSONAL_DETAILS
    {
        public string INC_ID { get; set; }
        public string RELATIONSHIP_ID { get; set; }
        public string EMPLOYEE_ID { get; set; }
        public string OCCUPATION { get; set; }
        public string NATIONALITY { get; set; }
        public string DOB { get; set; }
        public string PASSPORT_NUMBER { get; set; }
        public string LENGTH_OF_SERVICE { get; set; }
        public string CONTACT_PHONE_NUMBER { get; set; }
        public string GENDER { get; set; }
    }

    public class RISK_ASSESSMENT_DETAILS
    {
        public string INC_ID { get; set; }
        public string RISK_ASSESSMENT_ID { get; set; }
    }

    public class DECLARATION_INJURED_PERSON
    {
        public string INC_ID { get; set; }
        public string NAME_INJURED_PERSON { get; set; }
        public string DATE { get; set; }
    }
    #endregion
}
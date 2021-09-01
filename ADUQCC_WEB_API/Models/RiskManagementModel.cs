using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADUQCC_WEB_API.Models
{
    public class RiskManagementModel
    {
    }

    #region [Risk Category Master]
    public class GET_RM_RISK_CAT_MASTER
    {
        public string RISK_CAT_MAS_ID { get; set; }
        public string RISK_CAT_MAS_NAME { get; set; }
        public string RISK_CAT_MAS_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }

    public class ADD_RM_RISK_CAT_MASTER
    {
        public string RISK_CAT_MAS_ID { get; set; }
        public string RISK_CAT_MAS_NAME { get; set; }
        public string RISK_CAT_MAS_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Hazard Master]
    public class GET_RM_HAZARD_MASTER
    {
        public string HAZARD_MAS_ID { get; set; }
        public string HAZ_RISK_CAT_MAS_ID { get; set; }
        public string HAZARD_MAS_NAME { get; set; }
        public string HAZARD_MAS_NAME_AR { get; set; }
        public string RISK_CAT_MAS_NAME { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }

    public class ADD_RM_HAZARD_MASTER
    {
        public string HAZARD_MAS_ID { get; set; }
        public string HAZ_RISK_CAT_MAS_ID { get; set; }
        public string HAZARD_MAS_NAME { get; set; }
        public string HAZARD_MAS_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Risks And Other Risks]
    public class GET_RM_RISKS_OTHER_RISKS
    {
        public string RISKS_OTHER_RISKS_ID { get; set; }
        public string RISK_CAT_MAS_ID { get; set; }
        public string RISKS_HAZARD_MAS_ID { get; set; }
        public string RISKS_OTHER_RISKS_NAME { get; set; }
        public string RISKS_OTHER_RISKS_NAME_AR { get; set; }
        public string RISK_CAT_MAS_NAME { get; set; }
        public string HAZARD_MAS_NAME { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }

    public class ADD_RM_RISKS_OTHER_RISKS
    {
        public string RISKS_OTHER_RISKS_ID { get; set; }
        public string RISK_CAT_MAS_ID { get; set; }
        public string RISKS_HAZARD_MAS_ID { get; set; }
        public string RISKS_OTHER_RISKS_NAME { get; set; }
        public string RISKS_OTHER_RISKS_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Persons/Groups Exposed]
    public class GET_RM_PERSONS_GROUPS
    {
        public string PERSON_GROUP_ID { get; set; }
        public string RISK_CAT_MAS_ID { get; set; }
        public string PG_HAZARD_MAS_ID { get; set; }
        public string PERSON_GROUP_NAME { get; set; }
        public string PERSON_GROUP_NAME_AR { get; set; }
        public string RISK_CAT_MAS_NAME { get; set; }
        public string HAZARD_MAS_NAME { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }

    public class ADD_RM_PERSONS_GROUPS
    {
        public string PERSON_GROUP_ID { get; set; }
        public string RISK_CAT_MAS_ID { get; set; }
        public string PG_HAZARD_MAS_ID { get; set; }
        public string PERSON_GROUP_NAME { get; set; }
        public string PERSON_GROUP_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Details of any Existing Controls]
    public class GET_RM_DETAILS_EXIST_CONT
    {
        public string DETAILS_EXIST_CONT_ID { get; set; }
        public string RISK_CAT_MAS_ID { get; set; }
        public string DEC_HAZARD_MAS_ID { get; set; }
        public string DETAILS_EXIST_CONT_NAME { get; set; }
        public string DETAILS_EXIST_CONT_NAME_AR { get; set; }
        public string RISK_CAT_MAS_NAME { get; set; }
        public string HAZARD_MAS_NAME { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }

    public class ADD_RM_DETAILS_EXIST_CONT
    {
        public string DETAILS_EXIST_CONT_ID { get; set; }
        public string RISK_CAT_MAS_ID { get; set; }
        public string DEC_HAZARD_MAS_ID { get; set; }
        public string DETAILS_EXIST_CONT_NAME { get; set; }
        public string DETAILS_EXIST_CONT_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Additional Control Measures]
    public class GET_RM_ADD_CONT_MEAS
    {
        public string ADD_CONT_MEAS_ID { get; set; }
        public string RISK_CAT_MAS_ID { get; set; }
        public string ACM_HAZARD_MAS_ID { get; set; }
        public string ADD_CONT_MEAS_NAME { get; set; }
        public string ADD_CONT_MEAS_NAME_AR { get; set; }
        public string RISK_CAT_MAS_NAME { get; set; }
        public string HAZARD_MAS_NAME { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }

    public class ADD_RM_ADD_CONT_MEAS
    {
        public string ADD_CONT_MEAS_ID { get; set; }
        public string RISK_CAT_MAS_ID { get; set; }
        public string ACM_HAZARD_MAS_ID { get; set; }
        public string ADD_CONT_MEAS_NAME { get; set; }
        public string ADD_CONT_MEAS_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Opportunities and other opportunities]
    public class GET_RM_OPPORTUNITIES
    {
        public string OPPORTUNITIES_ID { get; set; }
        public string RISK_CAT_MAS_ID { get; set; }
        public string OPTY_HAZARD_MAS_ID { get; set; }
        public string OPPORTUNITIES_NAME { get; set; }
        public string OPPORTUNITIES_NAME_AR { get; set; }
        public string RISK_CAT_MAS_NAME { get; set; }
        public string HAZARD_MAS_NAME { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }

    public class ADD_RM_OPPORTUNITIES
    {
        public string OPPORTUNITIES_ID { get; set; }
        public string RISK_CAT_MAS_ID { get; set; }
        public string OPTY_HAZARD_MAS_ID { get; set; }
        public string OPPORTUNITIES_NAME { get; set; }
        public string OPPORTUNITIES_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }


    }

    #endregion

    #region [Critical Hazard Master]
    public class GET_RM_CRIT_HAZARD_MASTER
    {
        public string CRIT_HAZARD_MAS_ID { get; set; }
        public string CRIT_HAZARD_MAS_NAME { get; set; }
        public string CRIT_HAZARD_MAS_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }

    public class ADD_RM_CRIT_HAZARD_MASTER
    {
        public string CRIT_HAZARD_MAS_ID { get; set; }
        public string CRIT_HAZARD_MAS_NAME { get; set; }
        public string CRIT_HAZARD_MAS_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }

    }

    #endregion

    #region [Non Critical Hazard Master]
    public class GET_RM_NON_CRIT_HAZ_MASTER
    {
        public string NON_CRIT_HAZ_MAS_ID { get; set; }
        public string NON_CRIT_HAZ_MAS_NAME { get; set; }
        public string NON_CRIT_HAZ_MAS_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }

    public class ADD_RM_NON_CRIT_HAZ_MASTER
    {
        public string NON_CRIT_HAZ_MAS_ID { get; set; }
        public string NON_CRIT_HAZ_MAS_NAME { get; set; }
        public string NON_CRIT_HAZ_MAS_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }

    }

    #endregion

    #region [Non-Routine and Emergencies]
    public class GET_RM_NON_ROUT_EMERG_MASTER
    {
        public string NON_ROUT_EMERG_ID { get; set; }
        public string NON_ROUT_EMERG_NAME { get; set; }
        public string NON_ROUT_EMERG_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }

    public class ADD_RM_NON_ROUT_EMERG_MASTER
    {
        public string NON_ROUT_EMERG_ID { get; set; }
        public string NON_ROUT_EMERG_NAME { get; set; }
        public string NON_ROUT_EMERG_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }

    }

    #endregion

    #region [Existing control measures for identified hazard]
    public class GET_RM_EXISTING_CMIH_MASTER
    {
        public string EXISTING_CMIH_MAS_ID { get; set; }
        public string EXISTING_CMIH_MAS_NAME { get; set; }
        public string EXISTING_CMIH_MAS_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }

    public class ADD_RM_EXISTING_CMIH_MASTER
    {
        public string EXISTING_CMIH_MAS_ID { get; set; }
        public string EXISTING_CMIH_MAS_NAME { get; set; }
        public string EXISTING_CMIH_MAS_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }

    }

    #endregion

    

}
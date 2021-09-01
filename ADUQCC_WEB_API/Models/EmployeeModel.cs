using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADUQCC_WEB_API.Models
{
    public class EmployeeModel
    {
    }

    public class GET_EMPLOYEE_DETAILS
    {
        public string EMPLOYEE_ID { get; set; }
        public string EMPLOYEE_NAME { get; set; }
        public string STATUS { get; set; }
        public string CREATED_DATE { get; set; }
    }

    public class ADD_EMPLOYEE_DETAILS
    {
        public string EMP_ID { get; set; }
        public string EMP_FIRSTNAME { get; set; }
        public string EMP_LASTNAME { get; set; }
        public string EMP_GENDER { get; set; }
        public string EMP_NATIONALITY_ID { get; set; }
        public string EMP_DESIGNATION_ID { get; set; }
        public string EMP_LOCATION_ID { get; set; }
        public string EMP_BUILDING_ID { get; set; }
        public string EMP_SECTOR_ID { get; set; }
        public string EMP_DEPARTMENT_ID { get; set; }
        public string EMP_SECTION_ID { get; set; }
        public string EMP_EMAIL { get; set; }
        public string EMP_PHONE_NO { get; set; }
        public string EMP_TEL_NO { get; set; }
        public string EMP_PASSWORD { get; set; }
        public string EMP_STATUS { get; set; }
        public string CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string EMP_USERNAME { get; set; }
        public string EMP_NAME_AR { get; set; }
        public string STATUS_CODE { get; set; }
        public string MESSAGE { get; set; }
        public string DESI_NAME_EN { get; set; }
    }

    public class RETURN_MESSAGE
    {
        public string STATUS_CODE { get; set; }
        public string MESSAGE { get; set; }
    }

    public class HEALTH_VITAL
    {
        public List<HEALTH_VITAL_LIST> HEALTH_VITAL_LIST { get; set; }
    }

    public class HEALTH_VITAL_LIST
    {
        public string HEALTH_VITAL_NAME { get; set; }
        public string EMP_ID { get; set; }
        public string YES_OR_NO { get; set; }
    }
}
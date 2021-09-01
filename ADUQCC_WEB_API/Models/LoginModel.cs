using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADUQCC_WEB_API.Models
{
    public class LoginModel
    {
        public long EMP_ID { get; set; }
        public string EMP_FIRSTNAME { get; set; }
        public string EMP_LASTNAME { get; set; }
        public string EMP_GENDER { get; set; }
        public int EMP_NATIONALITY_ID { get; set; }
        public int EMP_DESIGNATION_ID { get; set; }
        public int EMP_LOCATION_ID { get; set; }
        public int EMP_BUILDING_ID { get; set; }
        public int EMP_SECTOR_ID { get; set; }
        public int EMP_DEPARTMENT_ID { get; set; }
        public int EMP_SECTION_ID { get; set; }
        public string EMP_EMAIL { get; set; }
        public string EMP_PHONE_NO { get; set; }
        public string EMP_TEL_NO { get; set; }
        public string EMP_PASSWORD { get; set; }
        public bool EMP_STATUS { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public long CREATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public long UPDATED_BY { get; set; }
        public string EMP_USERNAME { get; set; }
        public int EMP_LANGUAGE { get; set; }
    }

    public class GET_USER_DETAILS
    {
        public string MESSAGE { get; set; }
        public string LANG_ID { get; set; }
        public string DISPLAY_NAME { get; set; }
        public string DESI_NAME { get; set; }
        public string EMP_USERNAME { get; set; }
        public string EMP_PASSWORD { get; set; }
        public string EMP_STATUS { get; set; }
        public string STATUS { get; set; }
    }
}
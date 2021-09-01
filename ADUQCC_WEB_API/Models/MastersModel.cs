using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADUQCC_WEB_API.Models
{
    public class GET_LOCATION_MASTER
    {
        public string LOC_ID { get; set; }
        public string LOC_NAME { get; set; }
        public string LOC_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }

    public class ADD_LOCATION_MASTER
    {
        public string LOC_ID { get; set; }
        public string LOC_NAME { get; set; }
        public string CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string LOC_NAME_AR { get; set; }
        public string STATUS_CODE { get; set; }
    }

    public class GET_BUILDING_MASTER
    {
        public string BUIL_ID { get; set; }
        public string LOC_ID { get; set; }
        public string LOC_NAME { get; set; }
        public string BUIL_NAME { get; set; }
        public string BUIL_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }

    public class ADD_BUILDING_MASTER
    {
        public string BUIL_ID { get; set; }
        public string LOC_ID { get; set; }
        public string BUIL_NAME { get; set; }
        public string BUIL_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string STATUS_CODE { get; set; }
    }

    public class ADD_DEPARTMENT_MASTER
    {
        public string DEP_ID { get; set; }
        public string SEC_ID { get; set; }
        public string DEP_NAME { get; set; }
        public string CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string DEP_NAME_AR { get; set; }
        public string STATUS_CODE { get; set; }
    }

    public class GET_DEPARTMENT_MASTER
    {
        public string DEP_ID { get; set; }
        public string SEC_NAME_EN { get; set; }
        public string DEP_NAME { get; set; }
        public string DEP_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }


    public class ADD_SECTION_LAB_MASTER
    {
        public string SEC_LAB_ID { get; set; }
        public string SEC_LAB_TYPE { get; set; }
        public string DEP_ID { get; set; }
        public string SEC_LAB_NAME { get; set; }
        public string CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public string UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public string SEC_LAB_NAME_AR { get; set; }
        public string STATUS_CODE { get; set; }
    }

    public class GET_SECTION_LAB_MASTER
    {
        public string SEC_LAB_ID { get; set; }
        public string SEC_LAB_TYPE { get; set; }
        public string DEP_NAME { get; set; }
        public string SEC_LAB_NAME { get; set; }
        public string SEC_LAB_NAME_AR { get; set; }
        public string CREATED_DATE { get; set; }
        public string STATUS { get; set; }
    }

    public class SectorModel
    {
        public long SEC_ID { get; set; }
        public long BUIL_ID { get; set; }
        public string SEC_TYPE { get; set; }
        public string SEC_NAME_EN { get; set; }
        public string SEC_NAME_ARB { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public bool STATUS { get; set; }
        public int LANG_ID { get; set; }
        public long SEC_IDENTITY { get; set; }
        public string MESSAGE { get; set; }
        public string STATUS_CODE { get; set; }
    }

    public class GET_SECTOR_DETAILS
    {
        public long SEC_ID { get; set; }
        public string BUIL_NAME_EN { get; set; }
        public string SEC_NAME_EN { get; set; }
        public string SEC_NAME_ARB { get; set; }
        public string CREATED_DATE { get; set; }
    }

    public class SectorTypeModel
    {
        public long SEC_TYPE_ID { get; set; }
        public string SEC_TYPE_NAME_EN { get; set; }
        public string SEC_TYPE_NAME_ARB { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public bool STATUS { get; set; }
        public int LANG_ID { get; set; }
        public long SEC_TYPE_IDENTITY { get; set; }
        public string MESSAGE { get; set; }
        public string STATUS_CODE { get; set; }
    }

    public class GET_SECTORTYPE_DETAILS
    {
        public long SEC_TYPE_ID { get; set; }
        public string SEC_TYPE_NAME_EN { get; set; }
        public string SEC_TYPE_NAME_ARB { get; set; }
        public string CREATED_DATE { get; set; }
    }

    public class GET_BUILDING_DETAILS
    {
        public string LOC_NAME_EN { get; set; }
        public long BUIL_ID { get; set; }
        public string BUIL_NAME_EN { get; set; }
        public string BUIL_NAME_ARB { get; set; }
        public string CREATED_DATE { get; set; }
    }

    public class DesignationModel
    {
        public long DESI_ID { get; set; }
        public string DESI_NAME_EN { get; set; }
        public string DESI_NAME_ARB { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public bool STATUS { get; set; }
        public int LANG_ID { get; set; }
        public long DESI_IDENTITY { get; set; }
        public string MESSAGE { get; set; }
        public string STATUS_CODE { get; set; }
    }

    public class GET_DESIGNATION_DETAILS
    {
        public long DESI_ID { get; set; }
        public string DESI_NAME_EN { get; set; }
        public string DESI_NAME_ARB { get; set; }
        public string CREATED_DATE { get; set; }
    }
}
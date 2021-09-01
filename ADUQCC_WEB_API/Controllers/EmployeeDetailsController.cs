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
    [RoutePrefix("api/EmployeeDetails")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployeeDetailsController : ApiController
    {
        [Route("GetEmployeeDetails")]
        // GET: api/UserDetails
        public IEnumerable<GET_EMPLOYEE_DETAILS> GetEmployeeDetails()
        {
            Employee_Repository _userRepo = new Employee_Repository();
            return _userRepo.GetEmployeeDetails();
        }

        [Route("AddEmployeeDetails")]
        // GET: api/UserDetails
        public ADD_EMPLOYEE_DETAILS AddEmployeeDetails(ADD_EMPLOYEE_DETAILS _EMPLOYEE_DETAILS)
        {
            Employee_Repository _userRepo = new Employee_Repository();
            return _userRepo.AddEmployeeDetails(_EMPLOYEE_DETAILS);
        }

        [Route("DeleteEmployeeDetails")]
        // GET: api/UserDetails
        public RETURN_MESSAGE DeleteEmployeeDetails(string EMP_ID)
        {
            Employee_Repository _userRepo = new Employee_Repository();
            return _userRepo.DeleteEmployeeDetails(EMP_ID);
        }

        [Route("GetEmployeeEditDetails")]
        //GET: api/UserDetailsGetEmployeeEditDetails
        public ADD_EMPLOYEE_DETAILS GetEmployeeEditDetails(string EMP_ID)
        {
            Employee_Repository _userRepo = new Employee_Repository();
            return _userRepo.EditEmployeeDetails(EMP_ID);
        }

        [Route("UpdateEmployeeDetails")]
        //GET: api/UserDetails
        public ADD_EMPLOYEE_DETAILS PUT(ADD_EMPLOYEE_DETAILS _EMPLOYEE_DETAILS)
        {
            Employee_Repository _userRepo = new Employee_Repository();
            return _userRepo.AddEmployeeDetails(_EMPLOYEE_DETAILS);
        }

        [Route("AddHealthVitalsDetails")]
        //GET: api/UserDetails
        public RETURN_MESSAGE AddHealthVitalsDetails(HEALTH_VITAL _HEALTH_VITAL)
        {
            Employee_Repository _userRepo = new Employee_Repository();
            return _userRepo.AddHealthVitalsDetails(_HEALTH_VITAL);
        }

        [Route("GetHealthVitalsDetails")]
        //GET: api/UserDetailsGetEmployeeEditDetails
        public IEnumerable<HEALTH_VITAL_LIST> GetHealthVitalsDetails(string EMP_ID)
        {
            Employee_Repository _userRepo = new Employee_Repository();
            return _userRepo.GetHealthVitalsDetails(EMP_ID);
        }

        [Route("GetActiveDeactiveStatus")]
        //GET: api/UserDetails
        public RETURN_MESSAGE GetActiveDeactiveStatus(string EMP_ID, string STATUS, string PASSWORD, string USERNAME)
        {
            Employee_Repository _userRepo = new Employee_Repository();
            return _userRepo.GetActiveDeactiveStatus(EMP_ID, STATUS, PASSWORD, USERNAME);
        }
    }
}

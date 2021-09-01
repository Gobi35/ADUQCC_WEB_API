using ADUQCC_WEB_API.Models;
using ADUQCC_WEB_API.Repository;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;
using System.Web.Http.Filters;
//using static ADUQCC_WEB_API.Models.RegisterModel;

namespace ADUQCC_WEB_API.Controllers
{
    //[Authorize]
    [RoutePrefix("api/Account")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AccountController : ApiController
    {
        Account_Repository objDal = new Account_Repository();
        public class LogMetadata
        {
            public string RequestContentType { get; set; }
            public string RequestUri { get; set; }
            public string Request_content { get; set; }
            public string Response_content { get; set; } = "OK";
            public string RequestMethod { get; set; }
            public DateTime? RequestTimestamp { get; set; }
            public string ResponseContentType { get; set; }
            public HttpStatusCode ResponseStatusCode { get; set; }
            public DateTime? ResponseTimestamp { get; set; }
        }

        public class CustomLogHandler : DelegatingHandler
        {
            //protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            //{
            //    var logMetadata = BuildRequestMetadata(request);
            //    var response = await base.SendAsync(request, cancellationToken);
            //    logMetadata = BuildResponseMetadata(logMetadata, response);
            //    SendToLog(logMetadata);
            //    return response;
            //}


            //private LogMetadata BuildRequestMetadata(HttpRequestMessage request)
            //{
            //    var requsetcontent = request.Content;
            //    LogMetadata log = new LogMetadata
            //    {
            //        RequestMethod = request.Method.Method,
            //        RequestTimestamp = DateTime.Now,
            //        RequestUri = request.RequestUri.ToString(),
            //        RequestContentType = (request.Content.Headers.ContentLength.ToString() == "0") ? null : request.Content.Headers.ContentType.MediaType,
            //        Request_content = (request.Content.Headers.ContentLength.ToString() == "0") ? null : requsetcontent.ReadAsStringAsync().Result.ToString()
            //    };
            //    return log;
            //}
            //private LogMetadata BuildResponseMetadata(LogMetadata logMetadata, HttpResponseMessage response)
            //{
            //    var responsecontent = response.Content;
            //    logMetadata.ResponseStatusCode = response.StatusCode;
            //    logMetadata.ResponseTimestamp = DateTime.Now;
            //    logMetadata.ResponseContentType = response.Content.Headers.ContentType.MediaType;

            //    if (logMetadata.ResponseStatusCode.ToString() != "OK")
            //    {
            //        logMetadata.Response_content = responsecontent.ReadAsStringAsync().Result.ToString();
            //    }

            //    return logMetadata;
            //}
            //private bool SendToLog(LogMetadata logMetadata)
            //{
            //    Account_Repository obj = new Account_Repository();  //insert requested parameters for tracking purpose 
            //    obj.API_REQUEST_AND_RESPONSE_DETAILS("ADQCC API REQUEST", logMetadata.RequestMethod, logMetadata.RequestContentType,
            //        logMetadata.RequestUri, logMetadata.Request_content, logMetadata.RequestTimestamp,
            //        logMetadata.ResponseTimestamp, logMetadata.Response_content, logMetadata.ResponseStatusCode.ToString(),
            //        logMetadata.ResponseContentType);
            //    return true;
            //}
        }

        public class ValidateModelRegister : ActionFilterAttribute
        {
            public override void OnActionExecuting(HttpActionContext actionContext)
            {
                if (actionContext.ModelState.IsValid == false)
                {
                    var errors = actionContext.ModelState
                                      .Values
                                      .SelectMany(m => m.Errors
                                                        .Select(e => e.ErrorMessage));

                    string errormessage = "";

                    if (errors.ToList()[0].ToString() == "")
                    {
                        errormessage = "Invalid Json!";
                    }
                    else
                    {
                        errormessage = errors.ToList()[0].ToString();
                    }
                    var response = actionContext
                                    .Request
                                    .CreateErrorResponse(HttpStatusCode.BadRequest, errormessage);
                    actionContext.Response = response;
                }
            }
        }

        public class MyActionFilter : ActionFilterAttribute
        {
            public override void OnActionExecuting(HttpActionContext actionContext)
            {
                var result = "";
                try
                {
                    result = actionContext.Request.Headers.Authorization.Parameter;
                }
                catch (Exception ex)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(
                HttpStatusCode.Unauthorized,
                new { message = "Authorization has been denied for this request." },
                actionContext.ControllerContext.Configuration.Formatters.JsonFormatter);
                }
                var TokenVerficationurl = ConfigurationManager.AppSettings["PatientTokenVerficationURL"].ToString();
                var res = CallRestMethodWithAuthorization(TokenVerficationurl, result);

                if (res.ToString() == "The remote server returned an error: (401) Unauthorized.")
                {
                    actionContext.Response = actionContext.Request.CreateResponse(
                 HttpStatusCode.Unauthorized,
                 new { message = "Authorization has been denied for this request." },
                 actionContext.ControllerContext.Configuration.Formatters.JsonFormatter);
                }
            }
        }
        public static string CallRestMethodWithAuthorization(string url, string Token)
        {
            HttpWebRequest req = null;
            HttpWebResponse rsp = null;
            string result = "";
            try
            {
                string uri = url;
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                req = WebRequest.Create(uri) as HttpWebRequest;

                req.Headers["Authorization"] = "Bearer " + Token;
                req.Method = "GET";
                rsp = req.GetResponse() as HttpWebResponse;

                string statusCode = rsp.StatusDescription;

                string ss = rsp.StatusDescription.ToString();

                StreamReader sr = new StreamReader(rsp.GetResponseStream());
                result = sr.ReadToEnd();
                sr.Close();
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

       
        //[Route("LOGIN")]
        //public dynamic LOGIN([FromBody] LOGIN _login)
        //{
        //    try
        //    {
        //        if (_login == null || _login.Login_Mode == null)
        //        {
        //            RETURN_MESSAGE errormessage = new RETURN_MESSAGE()
        //            {
        //                MESSAGE = "Invalid Json Received!"
        //            };
        //            return Request.CreateResponse(HttpStatusCode.BadRequest, errormessage);
        //        }
        //        string Login_User = _login.Login_User.ToString();
        //        string Password = _login.Password.ToString();
        //        string Lang_Id = _login.Lang_Id.ToString();
        //        string Designation_Id = _login.Designation_Id.ToString();
        //        string Login_Mode = _login.Login_Mode.ToString();
        //        string longitude = string.IsNullOrEmpty(_login.Longitude) ? null : _login.Longitude.ToString();
        //        string latitude = string.IsNullOrEmpty(_login.Latitude) ? null : _login.Latitude.ToString();
        //        string IMEI = string.IsNullOrEmpty(_login.IMEI) ? null : _login.IMEI.ToString();
        //        string Firebase_ID = string.IsNullOrEmpty(_login.Firebase_ID) ? null : _login.Firebase_ID.ToString();
        //        string Android_IOS_Web = string.IsNullOrEmpty(_login.Android_IOS_Web) ? null : _login.Android_IOS_Web.ToString();

        //        var response = objDal.LOGIN(Login_User, Password, Lang_Id, Designation_Id, Login_Mode, latitude, longitude, IMEI, Firebase_ID, Android_IOS_Web);
        //        if (response.Rows.Count > 0)
        //        {
        //            response.Columns.Add(new DataColumn("access_token", typeof(string)));
        //            response.Columns.Add(new DataColumn("token_type", typeof(string)));
        //            response.Columns.Add(new DataColumn("expires_in", typeof(string)));
        //            response.Columns.Add(new DataColumn("refresh_token", typeof(string)));
        //            response.Columns.Add(new DataColumn("issued", typeof(string)));
        //            response.Columns.Add(new DataColumn("expires", typeof(string)));

        //            if (response.Rows[0]["status"].ToString() == "200")
        //            {
        //                string data = "username=" + Login_User + "&password=" + Password + "&grant_type=password";
        //                using (WebClient client = new WebClient())
        //                {
        //                    client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
        //                    string TokenURL = ConfigurationManager.AppSettings["TokenURL"].ToString();
        //                    var result = client.UploadString(TokenURL, data);
        //                    dynamic jsonToken = JObject.Parse(result);

        //                    response.Rows[0]["access_token"] = jsonToken["access_token"].ToString();
        //                    response.Rows[0]["token_type"] = jsonToken["token_type"].ToString();
        //                    response.Rows[0]["expires_in"] = jsonToken["expires_in"].ToString();
        //                    response.Rows[0]["refresh_token"] = jsonToken["refresh_token"].ToString();
        //                    response.Rows[0]["issued"] = jsonToken[".issued"].ToString();
        //                    response.Rows[0]["expires"] = jsonToken[".expires"].ToString();

        //                    var c = new
        //                    {
        //                        LOGIN = response
        //                    };

        //                    return Request.CreateResponse(HttpStatusCode.OK, c);
        //                }
        //            }
        //            else
        //            {
        //                var b = new
        //                {
        //                    LOGIN = response
        //                };
        //                return Request.CreateResponse(HttpStatusCode.BadRequest, b);
        //            }
        //        }
        //        else
        //        {
        //            RETURN_MESSAGE errormessage = new RETURN_MESSAGE()
        //            {
        //                MESSAGE = "Internal server error"
        //            };

        //            return Request.CreateResponse(HttpStatusCode.InternalServerError, errormessage);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}


        [Route("GetLoginDetails")]
        // GET: api/UserDetails
        public GET_USER_DETAILS GetLoginDetails(string UserName, string Password, string Desi_Id)
        {
            Account_Repository _userRepo = new Account_Repository();
            return _userRepo.GetLoginDetails(UserName, Password, Desi_Id);
        }
    }
}

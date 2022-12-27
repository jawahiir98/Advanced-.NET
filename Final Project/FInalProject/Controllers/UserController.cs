using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;

namespace FInalProject.Controllers
{
    public class UserController : ApiController
    {
        // GET: User
        [HttpGet]
        [Route("api/Users")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = UserServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [HttpGet]
        [Route("api/Users/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = UserServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Users/add")]
        [HttpPost]
        public HttpResponseMessage Add(UserDTO obj)
        {
            var data = UserServices.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/Users/delete")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = UserServices.Detele(id);
                if (data) return Request.CreateResponse(HttpStatusCode.OK, data);
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPost]
        [Route("api/Users/update")]
        public HttpResponseMessage Update(UserDTO obj)
        {
            try
            {
                var data = UserServices.Update(obj);
                if (data != null) return Request.CreateResponse(HttpStatusCode.OK, data);
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPost]
        [Route("api/Users/okay")]
        public HttpResponseMessage Okay(UserDTO obj)
        {
            try
            {
                var data = UserServices.Okay(obj);
                if(data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, data);
                }
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
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
    public class OrderController : ApiController
    {
        // GET: Order
        [HttpGet]
        [Route("api/Orders")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = OrderServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [HttpGet]
        [Route("api/Orders/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = OrderServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Orders/add")]
        [HttpPost]
        public HttpResponseMessage Add(OrderDTO obj)
        {
            var data = OrderServices.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/Orders/delete")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = OrderServices.Detele(id);
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
        [Route("api/Orders/update")]
        public HttpResponseMessage Update(OrderDTO obj)
        {
            try
            {
                var data = OrderServices.Update(obj);
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
    }
}
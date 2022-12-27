using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace FInalProject.Controllers
{
    public class ProductController : ApiController
    {
        // GET: Prodcut
        [HttpGet]
        [Route("api/products")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ProductServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [HttpGet]
        [Route("api/products/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = ProductServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/prodcuts/add")]
        [HttpPost]
        public HttpResponseMessage Add(ProductDTO obj)
        {
            var data = ProductServices.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/products/delete")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = ProductServices.Delete(id);
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
        [Route("api/products/update")]
        public HttpResponseMessage Update(ProductDTO obj)
        {
            try
            {
                var data = ProductServices.Update(obj);
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
        [HttpGet]
        [Route("api/product/sorted")]
        public HttpResponseMessage Sorted()
        {
            try
            {
                var data = ProductServices.SortByPrice();
                if (data != null) return Request.CreateResponse(HttpStatusCode.OK, data);
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
                }
            }
            catch(Exception ex)
            {
                return  Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
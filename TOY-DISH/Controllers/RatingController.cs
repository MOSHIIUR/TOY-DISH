using BusinessLayer.DTOs;
using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TOY_DISH.Controllers
{
    public class RatingController : ApiController
    {
        [HttpGet]
        [Route("api/ratings")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = RatingService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpPost]
        [Route("api/ratings/add")]
        public HttpResponseMessage Add(RatingDTO data)
        {
            try
            {
                var res = RatingService.Create(data);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", Data = data });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Inserted", Data = data });
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message, Data = data });
            }
        }

        [HttpGet]
        [Route("api/ratings/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, RatingService.Get(id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpPut]
        [Route("api/ratings/update")]
        public HttpResponseMessage Update(RatingDTO data)
        {
            try
            {
                var res = RatingService.Update(data);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated", Data = data });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Updated", Data = data });
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message, Data = data });
            }
        }

        [HttpDelete]
        [Route("api/ratings/Delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var res = RatingService.Delete(id);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Deleted", Data = id });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Deleted", Data = id });
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message, Data = id });
            }
        }
    }
}

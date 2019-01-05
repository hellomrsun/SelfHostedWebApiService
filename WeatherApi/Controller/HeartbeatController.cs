using System;
using System.Web.Http;

namespace WeatherApi.Controller
{
    public class HeartbeatController : ApiController
    {
        [HttpGet]
        [Route("api/v1/heartbeat/test")]
        public IHttpActionResult Test()
        {
            return Ok("hello");
        }

        [HttpGet]
        [Route("api/v1/heartbeat/currentDate")]
        public IHttpActionResult CurrentDate()
        {
            var date = DateTime.Now;
            return Ok(date);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ValueController : ApiController
    {
        [Route("api/GetValue")]
        public IHttpActionResult Get()
        {
            return Ok(1);
        }
    }
}

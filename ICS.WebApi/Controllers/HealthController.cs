using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ICS.WebApi.Controllers
{
    public class HealthController : ApiController
    {
        public string Get()
        {
            return "UP";
        }
    }
}

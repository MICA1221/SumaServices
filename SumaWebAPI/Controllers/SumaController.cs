using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SumaWebAPI.Controllers
{
    public class SumaController : ApiController
    {
        [HttpGet]
        [Route("api/suma")]
        public int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}


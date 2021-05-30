using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteTecnico.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class showmethecodeController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            var url = "https://github.com/avelar42/TesteTecnico";
            return new JsonResult(url);
        }
    }
}

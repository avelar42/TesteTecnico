using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteTecnico.Controllers
{
    [ApiController]
    [Route("showmethecode")]
    public class ShowmethecodeController : ControllerBase
    {
        /// <summary>
        /// Classe responsável pela chegada dos dados a API e retornar o link desse projeto no github.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var url = "https://github.com/avelar42/TesteTecnico";
            return new JsonResult(url);
        }
    }
}

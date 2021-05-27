using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service;

namespace TesteTecnico.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        private CalculoTaxaJuros taxaJuros = new CalculoTaxaJuros();

        [HttpGet]
        public IActionResult Get()
        {
            string result = "0,01";
            return new JsonResult(taxaJuros.GetTaxaDecimal());
        }
    }
}

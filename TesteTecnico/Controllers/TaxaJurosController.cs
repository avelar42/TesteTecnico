using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service;

namespace TesteTecnico.Controllers
{
    
    [ApiController]
    [Route("taxaJuros")]
    public class TaxaJurosController : ControllerBase
    {
        private CalculoTaxaJuros taxaJuros = new CalculoTaxaJuros();

        /// <summary>
        /// Classe responsável pela chegada dos dados a API e retornar a taxa de juros em decimal.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(taxaJuros.GetTaxaDecimal());
        }
    }
}

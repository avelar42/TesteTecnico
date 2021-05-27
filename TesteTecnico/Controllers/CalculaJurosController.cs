using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteTecnico.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private CalculoTaxaJuros _taxaJuros = new CalculoTaxaJuros();

        [HttpGet]
        public IActionResult Get(decimal valorInicial, int tempo)
        {
            var taxaJuros = _taxaJuros.GetTaxaDecimal();
            var result = Convert.ToDouble(valorInicial) * Math.Pow(1 + Convert.ToDouble(taxaJuros), tempo);
            return new JsonResult(Convert.ToDecimal(result.ToString("N2")));
        }

        //[HttpGet]
        //public IActionResult Get()
        //{
            
        //}
    }
}

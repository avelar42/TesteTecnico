using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Globalization;

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
            var resultado = (Convert.ToDouble(valorInicial) * Math.Pow(1 + Convert.ToDouble(taxaJuros), tempo)) * 100;
            return new JsonResult((Convert.ToDecimal(Math.Truncate(resultado)) / 100) * 1.0m);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Globalization;

namespace TesteTecnico.Controllers
{
    [ApiController]
    [Route("calculaJuros")]
    public class CalculaJurosController : ControllerBase
    {
        private CalculadoraJurosCompostos _calculadoraJurosCompostos = new CalculadoraJurosCompostos();

        /// <summary>
        /// Classe responsável pela chegada dos dados a API e retornar o calculo de juros compostos.
        /// <param name="valorInicial"/>
        /// <param name="tempo"/>
        /// </summary>
        /// <returns>Json(Decimal)</returns>
        [HttpGet]
        public IActionResult Get(decimal valorInicial, int tempo)
        {
            return new JsonResult(_calculadoraJurosCompostos.CalcularJurosCompostos(valorInicial, tempo));
        }
    }
}

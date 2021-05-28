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
        private CalculadoraJurosCompostos _calculadoraJurosCompostos = new CalculadoraJurosCompostos();

        [HttpGet]
        public IActionResult Get(decimal valorInicial, int tempo)
        {
            return new JsonResult(_calculadoraJurosCompostos.CalcularJurosCompostos(valorInicial, tempo));
        }
    }
}

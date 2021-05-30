using Service;
using System;
using Xunit;

namespace TesteCalculadoras
{
    /// <summary>
    /// Classe responsável pelos testes unitarios.
    /// </summary>
    public class TesteTaxas
    {
        private readonly CalculoTaxaJuros _taxaJuros;
        private readonly CalculadoraJurosCompostos _calculadoraJurosCompostos;
        public TesteTaxas()
        {
            _taxaJuros = new CalculoTaxaJuros();
            _calculadoraJurosCompostos = new CalculadoraJurosCompostos();
        }
        /// <summary>
        /// Classe responsável pela validação dos calculos unitarios de taxa de juros em decimal.
        /// </summary>
        [Fact]
        public void ValidarCalculoDeTaxa()
        {
            var result = 0.01m;
            var taxaJuros = _taxaJuros.GetTaxaDecimal();
            Assert.Equal(taxaJuros, result);
        }
        /// <summary>
        /// Classe responsável pela validação dos calculos unitarios de taxa de juros compostos.
        /// </summary>
        [Fact]
        public void ValidarCalculadoraJurosCompostos()
        {
            var result = 105.10m;
            decimal valorInicial = 100;
            int tempo = 5; 
            var resultado = _calculadoraJurosCompostos.CalcularJurosCompostos(valorInicial, tempo);
            Assert.Equal(resultado, result);
        }
    }
}

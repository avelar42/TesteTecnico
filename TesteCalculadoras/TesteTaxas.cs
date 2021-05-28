using Service;
using System;
using Xunit;

namespace TesteCalculadoras
{
    public class TesteTaxas
    {
        private readonly CalculoTaxaJuros _taxaJuros;
        private readonly CalculadoraJurosCompostos _calculadoraJurosCompostos;
        public TesteTaxas()
        {
            _taxaJuros = new CalculoTaxaJuros();
            _calculadoraJurosCompostos = new CalculadoraJurosCompostos();
        }

        [Fact]
        public void ValidarCalculoDeTaxa()
        {
            var result = 0.01m;
            var taxaJuros = _taxaJuros.GetTaxaDecimal();
            Assert.Equal(taxaJuros, result);
        }

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

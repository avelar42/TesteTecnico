using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class CalculadoraJurosCompostos
    {
        private CalculoTaxaJuros _taxaJuros = new CalculoTaxaJuros();
        /// <summary>
        /// Classe responsável pelos calculo de juros compostos.
        /// <param name="valorInicial"/>
        /// <param name="tempo"/>
        /// </summary>
        /// <returns>decimal</returns>
        public decimal CalcularJurosCompostos(decimal valorInicial, int tempo)
        {
            var taxaJuros = _taxaJuros.GetTaxaDecimal();
            var resultado = (Convert.ToDouble(valorInicial) * Math.Pow(1 + Convert.ToDouble(taxaJuros), tempo)) * 100;
            return ((Convert.ToDecimal(Math.Truncate(resultado)) / 100) * 1.0m);
        }
    }
}

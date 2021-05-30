using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class CalculoTaxaJuros
    {
        decimal taxaJuros = 1;

        /// <summary>
        /// Classe responsável pelo calculo dos juros para decimal.
        /// </summary>
        /// <returns></returns>
        public decimal GetTaxaDecimal()
        {
            var response = taxaJuros / 100;
            return response;
        }
    }
}

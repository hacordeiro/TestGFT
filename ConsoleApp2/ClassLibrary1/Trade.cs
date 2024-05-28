using Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Trade : ITrade
    {
        /// <summary>
        /// Método para verificar a categoria com base nos dados informados
        /// </summary>
        /// <param name="referenceDate"></param>
        /// <param name="trade"></param>
        /// <returns></returns>
        public string VerifyCategory(DateTime referenceDate, TradeDto trade)
        {
            // Condição incluida para validar a 2ª questão
            if (trade.IsPoliticallyExposed)
                return "PEP";

            if ((referenceDate - trade.NextPaymentDate).Days > 30)
                return "EXPIRED";

            if (trade.Value > 1000000 && trade.ClientSector == "Private")
                return "HIGHRISK";

            if (trade.Value > 1000000 && trade.ClientSector == "Public")
                return "MEDIUMRISK";

            return "None";
        }
    }
}

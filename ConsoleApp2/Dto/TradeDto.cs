using System;

namespace Dto
{
    public class TradeDto
    {
        public double Value { get; private set; } //indicates the transaction amount in dollars
        public string ClientSector { get; private set; } //indicates the client ́s sector which can be "Public" or "Private"
        public DateTime NextPaymentDate { get; private set; } //indicates when the next payment from the client to the bank is expected
        public bool IsPoliticallyExposed { get; private set; }

        /// <summary>
        /// Construtor para receber os campos base - 1ª questão
        /// </summary>
        /// <param name="value"></param>
        /// <param name="clientSector"></param>
        /// <param name="nextPaymentDate"></param>
        public TradeDto(double value, string clientSector, DateTime nextPaymentDate)
        {
            Value = value;
            ClientSector = clientSector;
            NextPaymentDate = nextPaymentDate;
        }

        /// <summary>
        /// Criado um construtor com o parametro novo isPoliticallyExposed para atender a questão 2 sem impactar o funcionamento
        /// da aplicação.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="clientSector"></param>
        /// <param name="nextPaymentDate"></param>
        /// <param name="isPoliticallyExposed"></param>
        public TradeDto(double value, string clientSector, DateTime nextPaymentDate, bool isPoliticallyExposed = false)
        {
            Value = value;
            ClientSector = clientSector;
            NextPaymentDate = nextPaymentDate;
            IsPoliticallyExposed = isPoliticallyExposed;
        }
    }
}

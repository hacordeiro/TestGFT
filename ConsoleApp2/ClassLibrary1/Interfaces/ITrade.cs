using Dto;
using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public interface ITrade
    {
        string VerifyCategory(DateTime referenceDate, TradeDto trade);
    }
}

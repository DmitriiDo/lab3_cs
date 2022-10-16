using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    public class Currency
    {
        public float Value;

    }

    public class CurrencyUSD : Currency
    {                 
        public static float ToRub;
        public static float ToEUR;

        public static implicit operator CurrencyEUR(CurrencyUSD usd)
        {
            return new CurrencyEUR { Value = usd.Value * ToEUR };
        }

        public static implicit operator CurrencyRUB(CurrencyUSD usd)
        {
            return new CurrencyRUB { Value = usd.Value * ToRub };
        }
    }

    public class CurrencyEUR : Currency
    {
        public static float ToUSD;
        public static float ToRub;

        public static implicit operator CurrencyUSD(CurrencyEUR eu)
        {
            return new CurrencyUSD { Value = eu.Value * ToUSD };
        }

        public static implicit operator CurrencyRUB(CurrencyEUR eu)
        {
            return new CurrencyRUB { Value = eu.Value * ToRub };
        }
    }

    public class CurrencyRUB : Currency
    {
        public static float ToUSD;
        public static float ToEUR;

        public static implicit operator CurrencyUSD(CurrencyRUB rub)
        {
            return new CurrencyUSD { Value = rub.Value * ToUSD };
        }

        public static implicit operator CurrencyEUR(CurrencyRUB rub)
        {
            return new CurrencyEUR { Value = rub.Value * ToEUR };
        }
    }
}

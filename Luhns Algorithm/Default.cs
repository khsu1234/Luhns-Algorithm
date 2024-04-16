using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luhns_Algorithm
{
    internal class Default
    {
        public static bool CreditCardValidator(string cardNumber)
        {
            try
            {
                int sum = 0;
                bool isSecond = false;

                for (int i = cardNumber.Length - 1; i >= 0; i--)
                {
                    int digit = cardNumber[i] - '0';

                   
                    if (isSecond)
                    {
                        digit *= 2;
                    }
                    sum += digit / 10;
                    sum += digit % 10;
                    isSecond = !isSecond;
                }
                return (sum % 10 == 0);
            }
            catch
            {
                return false;
            }
        }
    }
}
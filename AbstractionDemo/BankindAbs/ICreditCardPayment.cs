using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo.BankindAbs
{
    interface ICreditCardPayment
    {
        string CardNumber { get; set; }
        string ExpiryDate { get; set;}
        string CVV { get; set; }

        void AuthorizePayment();
    }
}

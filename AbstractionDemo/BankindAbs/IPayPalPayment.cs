using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo.BankindAbs
{
    interface IPayPalPayment
    {
        string PayPalId { get; set; }

        void AuthenticateUser();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AbstractionDemo.BankindAbs
{
    class PayPalProcessor : PaymentProcessor, IPayPalPayment
    {
        public string PayPalId { get; set; }

        public PayPalProcessor(string transactionId, decimal amount, string payPalId)
            : base(transactionId, amount)
        {
            PayPalId = payPalId;
        }

        public override void ProcessPayment()
        {
            AuthenticateUser();
            Console.WriteLine("Processing PayPal payment...");
            GenerateReceipt();
        }

        public void AuthenticateUser()
        {
            Console.WriteLine("Authenticating PayPal user...");
        }

    }

}

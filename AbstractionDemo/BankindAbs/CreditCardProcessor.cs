using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo.BankindAbs
{
     class CreditCardProcessor: PaymentProcessor, ICreditCardPayment
     {
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }


        public CreditCardProcessor(string transactionId, decimal amount, string cardNumber, string expiryDate, string cvv) : base(transactionId, amount)
        {
            CardNumber = cardNumber;
            ExpiryDate = expiryDate;
            CVV = cvv;
        }




        public void AuthorizePayment()
        {
            AuthorizePayment();
            Console.WriteLine("Processing credit card payment...");
            GenerateReceipt();
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("Authorizing credit card payment...");
        }
     }
}

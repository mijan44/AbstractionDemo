using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo.BankindAbs
{
    abstract class PaymentProcessor
    {
        public string TransactionId { get; set; }
        public decimal Amount { get; set; }


        public PaymentProcessor (string transactionId, decimal amount)
        {
            TransactionId = transactionId;
            Amount = amount;
        }


        public abstract void ProcessPayment();


        public void GenerateReceipt()
        {
            Console.WriteLine($"Transaction ID : {TransactionId}");
            Console.WriteLine($"Amount : {Amount}");
        }


    }
}

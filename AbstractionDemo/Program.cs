using AbstractionDemo;
using AbstractionDemo.BankindAbs;

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.MakeSound();
        myDog.Sleep();


        Bird myBird = new Bird();
        myBird.MakeSound();
        myBird.Sleep();




        PaymentProcessor creditCardPayment = new CreditCardProcessor("TXN12345", 100.00m, "4111111111111111", "12/25", "123");
        creditCardPayment.ProcessPayment();

        Console.WriteLine();


        PaymentProcessor payPalPayment = new PayPalProcessor("TXN67890", 200.00m, "user@example.com");
        payPalPayment.ProcessPayment();


    }
}
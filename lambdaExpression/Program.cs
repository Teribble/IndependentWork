using System;

namespace lambdaExpression
{
    public class Program
    {
        public static void Main()
        {
            BankAccount ba = new BankAccount("BD-145");
            ba.Notify += delegate (string? message) { Console.WriteLine(message); };
            ba.Notify += Display;
            ba.TopUpAccount(1000);
            ba.Withdraw(50000);
        }

        public static void Display(string? meassage)=>Console.WriteLine("lamda" + "\n" + meassage);
    }
}
using System;

namespace LearningDelegate
{
    public class Program
    {
        public static void Print(string? message)
        {
            Console.WriteLine(message);
        }
        public static void Main()
        {
            //BankAccount acc = new BankAccount("DDMB-144687");
            //acc.RegisterDelegate(Print);
            //acc.TopUpAccount(34567);
            //acc.Withdraw(18000);
            //acc.Withdraw(18000);

            Warrior warrior = new Warrior("Ork warrior", 120);
            Mage mage = new Mage("Skellet Mage", 65);

            mage.Decay(warrior);
            warrior.EndOfMove();
        }
    }
}
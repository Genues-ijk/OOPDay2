using System.Runtime.CompilerServices;

namespace OOPDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount AhmadAccount = new BankAccount();
            AhmadAccount.Balance = 5000;
            Console.WriteLine($"your balance is {AhmadAccount.Balance}");
            //            Console.WriteLine($"Your Balance:{AhmadAccount.GetBalance()}");

            /* 
             BankAccount RayanAccount = new BankAccount(); //Initialization, Default constructor
             RayanAccount.SetBalance(500);
             int Balance = RayanAccount.GetBalance();
             Console.WriteLine($"Rayan's Account Balance = {Balance}");

             BankAccount MohammedAccount = new BankAccount();
             MohammedAccount.SetBalance(1000);
             int MohammedBalance = MohammedAccount.GetBalance();
             Console.WriteLine($"Rayan's Account Balance = {MohammedBalance}");
            */

        }
    }
}

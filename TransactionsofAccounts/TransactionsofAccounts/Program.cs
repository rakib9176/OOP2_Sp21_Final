using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionsofAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Alif", "699", 5000);
            Account a2 = new Account("Alfi", "996", 3000);

            a1.Withdraw(5000);
            a1.Deposit(10000);
            a1.Transfer(a2, 600);
            a2.Transfer(a1, 300);

            Console.WriteLine("\n******************************\n");
            a1.ShowInfo();
            Console.WriteLine("******************************\n");
            a2.ShowInfo();

            Console.Write("End");
            Console.ReadLine();
        }
    }
}

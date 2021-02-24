using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingvsOverriddingDemonstrations
{
    interface IManageAccount
    {
        // static string showMessage() => "Welcome to ABC!!";
        void openAccount();
        void closeAccount();
    }

    interface IBankAccount
    {
        void deposit();
        void withdraw();
        void balance();
    }
    class SavingAccount : IBankAccount, IManageAccount
    {
        public void balance()
        {
            Console.WriteLine("Balance in Saving Account!!");
        }

        public void closeAccount()
        {
            Console.WriteLine("Closing Saving Account!!");
        }

        public void deposit()
        {
            Console.WriteLine("Deposit in Saving Account!!");
        }

        public void openAccount()
        {
            Console.WriteLine("Opening Saving Account!!");
        }

        public void withdraw()
        {
            Console.WriteLine("Withdrawal from Saving Account!!");
        }
    }

    class InterfaceExample
    {

        static void Main(string[] args)
        {
            SavingAccount savingAccount = new SavingAccount();
            savingAccount.openAccount();
            savingAccount.deposit();
            savingAccount.withdraw();
            savingAccount.balance();
            savingAccount.closeAccount();

            Console.ReadKey();
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OverloadingvsOverriddingDemonstrations
//{

//    abstract class ManageAccount
//    {
//        public abstract void OpenAccount();
//        public abstract void closeAccount();
//    }


//    abstract class BankAccount : ManageAccount
//    {
//        public static void showMessage()
//        {
//            Console.WriteLine("Welcome to ABC Bank!!");
//        }
//        public abstract void deposit();
//        public abstract void withdraw();
//        public abstract void balance();

//    }

//    class SavingAccount : BankAccount
//    {

//        public override void deposit()
//        {
//            Console.WriteLine("Deposit in Saving Account!!");
//        }

//        public override void withdraw()
//        {
//            Console.WriteLine("Withdrawal from Saving Account!!");
//        }
//        public override void balance()
//        {
//            Console.WriteLine("Balance in Saving Account!!");
//        }

//        public override void OpenAccount()
//        {
//            Console.WriteLine("Opening Saving Account!!");
//        }

//        public override void closeAccount()
//        {
//            Console.WriteLine("Closing Saving Account!!");
//        }
//        public void calculateTax()
//        {
//            Console.WriteLine("Calculating Tax for Saving Account!!");
//        }
//    }

//    class CurrentAccount : BankAccount
//    {
        
//        public override void deposit()
//        {
//            Console.WriteLine("Deposit in Current Account!!");
//        }

//        public override void withdraw()
//        {
//            Console.WriteLine("Withdrawal from Current Account!!");
//        }
//        public override void balance()
//        {
//            Console.WriteLine("Balance in Current Account!!");
//        }
//        public override void OpenAccount()
//        {
//            Console.WriteLine("Opening Current Account!!");
//        }

//        public override void closeAccount()
//        {
//            Console.WriteLine("Closing Current Account!!");
//        }
//    }


//    class AbstractClassesExample
//    {
//        static void Main(string[] args)
//        {
//            // Abstract Class can't be instantiated
//            // BankAccount bankAccount = new BankAccount();

//            BankAccount.showMessage();

//            SavingAccount savingAccount = new SavingAccount();
//            savingAccount.OpenAccount();
//            savingAccount.deposit();
//            savingAccount.withdraw();
//            savingAccount.balance();
//            savingAccount.calculateTax();
//            savingAccount.closeAccount();

//            Console.WriteLine("-----------------------------------");

//            CurrentAccount currentAccount = new CurrentAccount();
//            currentAccount.OpenAccount();
//            currentAccount.deposit();
//            currentAccount.withdraw();
//            currentAccount.balance();
//            currentAccount.closeAccount();

//            Console.ReadKey();
//        }
//    }
//}

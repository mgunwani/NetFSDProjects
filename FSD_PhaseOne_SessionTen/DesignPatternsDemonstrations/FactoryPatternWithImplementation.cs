/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemonstrations
{

    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
    public class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 5000;
        }

        public string GetCardType()
        {
            return "Money Back Credit Card";
        }

        public int GetCreditLimit()
        {
            return 50000;
        }
    }
    public class PlatinumCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 7000;
        }

        public string GetCardType()
        {
            return "Platinum Credit Card";
        }

        public int GetCreditLimit()
        {
            return 70000;
        }
    }
    public class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 9000;
        }

        public string GetCardType()
        {
            return "Titanium Credit Card";
        }

        public int GetCreditLimit()
        {
            return 90000;
        }
    }

    class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard creditCard = null;
            if (cardType == "MoneyBack")
            {
                creditCard = new MoneyBack();
            }
            else if (cardType == "Platinum")
            {
                creditCard = new PlatinumCard();
            }
            else if (cardType == "Titanium")
            {
                creditCard = new Titanium();
            }
            return creditCard;
        }
    }
    class FactoryPatternImplementation
    {
        static void Main(string[] args)
        {
            try
            {
                string cardType = "Platinum";

                ICreditCard creditCard = CreditCardFactory.GetCreditCard(cardType); 
                if (creditCard != null)
                {
                    Console.WriteLine("Credit Card Type : " + creditCard.GetCardType());
                    Console.WriteLine("Credit Card Limit : " + creditCard.GetCreditLimit());
                    Console.WriteLine("Credit Card Charge : " + creditCard.GetAnnualCharge());
                }
                else
                {
                    Console.WriteLine("Invalid Card Type!!");
                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
*/
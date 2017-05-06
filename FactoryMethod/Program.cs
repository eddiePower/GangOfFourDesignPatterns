using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a factory of type IcreditUnion
            var factory = new SavingsAcctFactory() as ICreditUnionFactory;
            //create a city savings account object by feeding in city string
            var citiAcct = factory.GetSavingsAccount("CITI-321");
            //create national savings account by passing in national string to factory
            var nationalAcct = factory.GetSavingsAccount("NATIONAL-987");

            //use formatted string by using $ and {} to display incline values.
            Console.WriteLine($"My citi balance is ${citiAcct.Balance}" +
                $" and national balance is ${nationalAcct.Balance}");
        }

    }

    // Product  -  interface
    public abstract class ISavingsAccount
    {
        //property
        public decimal Balance { get; set; }
    }

    // Concrete Product inherits from iSavings
    public class CitiSavingsAcct : ISavingsAccount
    {
        public CitiSavingsAcct()
        {
            Balance = 5000;
        }
    }

    // Concrete Product also inherits from iSaving
    public class NationalSavingsAcct : ISavingsAccount
    {
        public NationalSavingsAcct()
        {
            Balance = 2000;
        }
    }

    // Creator method interface
    interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string acctNo);
    }

    // Concrete Creators
    public class SavingsAcctFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string acctNo)
        {
            if (acctNo.Contains("CITI")) { return new CitiSavingsAcct(); }
            else
            if (acctNo.Contains("NATIONAL")) { return new NationalSavingsAcct(); }
            else
                throw new ArgumentException("Invalid Account Number");
        }
    }


}

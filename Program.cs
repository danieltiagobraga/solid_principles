using System;
using OPEN_CLOSE_PRINCIPLE;

namespace solid_principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLID PRINCIPLES");

            var c = new Customer("Daniel Braga", new DateTime(1986, 5, 12));
            Console.WriteLine($"Age: {c.GetAge()}");
            
            var acc = new Account();
            acc.MakeDeposit();
            acc.MakeWithdrawal();
            acc.GetAccountHistory();
            
            Console.ReadLine();
        }
    }


    /*
            “If you take the SOLID principles to their extremes, you arrive at something that makes Functional Programming look quite attractive” 
                                        
                                                                — Mark Seemann
    */
}

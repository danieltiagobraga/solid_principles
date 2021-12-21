/*
                                                Open/Closed Principle

    "Software entities (classes, modules, functions, etc) should be open for extensions, but closed for modification."


    This simply means that a class should be easily extendable without modifying the class itself. 
    
    We should extensions should be preferred over modifications.
        
    For that we we can use interfaces, extensions, partial classes 
*/
using System;

namespace OPEN_CLOSE_PRINCIPLE
{
    /*
        In the example below we'll extend the behaviour of the Customer class by using extensions
    */
    class Customer {
        private Customer() {}
        public Customer (string name, DateTime dateBirth) {
            this.Name = name;
            this.DateBirth = dateBirth;
        }

        public string Name { get; set; }
        public DateTime DateBirth  { get; set; }
    }

    static class CustomerExtensions {
        public static int GetAge(this Customer c) {
            return DateTime.Now.Year -  c.DateBirth.Year;
        }
    }

    /*
        Other alternative to extend the behaviour of a classes is using partial classes. 
        
        With that we can add extra funcionalites without changing the existing code.
    */
    partial class Account {
        public void MakeDeposit() {}
        public void MakeWithdrawal() {}
    }

    partial class Account {
        public void GetAccountHistory() {}
    }
}
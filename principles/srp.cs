/*
                            Single Responsability Principle 

            "Each software module should have one and only one reason to change"
            

    This means that a class should take care of only one responsibility (only one job to do). 
    
    As responsability we can have Persistence, Logging, Validation and/or Business Logic

    If we apply this principle our classes/functions will be more small, easy to explain, understand, implement and test.
    
    Besides that we will reduce the possibility of introducing bugs every time we need to change or refactor some part of the code.

    As an example of SRP violation we can consider the class AreaCalculator that is responsable for calculate the area of a shape. 
    If we need to change the formula of the square area we will need to change an function that is also responsable for other areas. 
    We can easy fix this violation by adding this responsability in each shape.

*/

namespace SRP_PRINCIPLE_VIOLATION
{   
    class Square
    {
        public int length { get; set; }        
    }

    class Circle
    {
        public int radius { get; set; }
    }

    class AreaCalculator
    {
        public int Area(IShape s)
        {
            if (s is Square) {
                return 0;   // implementation for Square
            }

            if (s is Circle) {
                return 0;   // implementation for Circle
            }

            return 0;
        }
    }


    interface IShape
    {
    }
}

/*

    VIOLATION FIXED

*/
namespace SRP_PRINCIPLE_FIXED
{   
    interface IShape
    {
        int Area();
    }
    
    class Square : IShape
    {
        public int length { get; set; }        

        public int Area() => 0; // implementation for Square
    }

    class Circle : IShape
    {
        public int radius { get; set; }

        public int Area() => 0; // implementation for Square
    }

    class AreaCalculator
    {
        public int Area(IShape s) => s.Area();
    }
}
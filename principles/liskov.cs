/*
                            Liskov substitution principle
            
                "Derived classes must be substitutable for their base classes."


    So LISKOV principle says that child class should not break parent class’s type definition and behavior.


*/

namespace LISKOV_PRINCIPLE
{
    abstract class Shape {
        public virtual void Volume() {
            // implementation here
        }
        public virtual void Area() {
            // implementation here
        }
    }

    class Circle : Shape {
        public override void Volume()
        {
            base.Volume();
        }

        public override void Area()
        {
            throw new System.NotImplementedException(); // This breaks the LSP principle 
        }
    }
}
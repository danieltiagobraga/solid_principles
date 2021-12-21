/*
                            Interface segregation principle

            "Client should not be forced to use a interface if it does not need it."


    In other words, it is better to have many smaller interfaces, than fewer, fatter interfaces. 


*/


namespace INTERFACE_SEGREGATION_PRINCIPLE
{
    interface IShape {
        decimal area();
        decimal volume();
    }

    // This interface didn't fit with all shape (e.g Circle, Rectangles didn't have volume, so the interface will break the principle)
}
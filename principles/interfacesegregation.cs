/*
                            Interface segregation principle

            "Client should not be forced to use a interface if it does not need it."


    In other words, it is better to have many smaller interfaces, than fewer, fatter interfaces. 


*/
namespace INTERFACE_SEGREGATION_PRINCIPLE_VIOLATION
{
    interface IShape {
        decimal area();
        decimal volume();
    }
}

namespace INTERFACE_SEGREGATION_PRINCIPLE_FIXED 
{
    interface IFlatShape {
        decimal area();
    }

    interface ISolidShape {
        decimal volume();
    }
}

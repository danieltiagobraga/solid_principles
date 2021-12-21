/*
                                    Dependency inversion principle

    "High level modules must not depend on the low level module, but they should depend on abstractions."


    This principle is primarily concerned with reducing dependencies amongst the code modules.

    Basically, our classes should not depend in other classes but in abstractions.

    The example below demonstrate a class that brokes this principle
*/

namespace DEPENDENCY_INVERSION_PRINCIPLE 
{
    class Configs {
        public EmailConfig emailConfig { get; set; }
        public DatabaseConfig databaseConfig {get;set;}
    }

    class EmailConfig {}
    class DatabaseConfig {}
}
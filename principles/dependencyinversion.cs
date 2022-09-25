/*
                                    Dependency inversion principle

    "High level modules must not depend on the low level module, but they should depend on abstractions."


    This principle is primarily concerned with reducing dependencies amongst the code modules.

    Basically, our classes should not depend in other classes but in abstractions.

    The example below demonstrate a class that brokes this principle
*/

namespace DEPENDENCY_INVERSION_PRINCIPLE_VIOLATION
{
    class Configs {
        public EmailConfig emailConfig { get; set; }
        public DatabaseConfig databaseConfig {get;set;}
    }

    class EmailConfig {}
    class DatabaseConfig {}

    // Fix Config class
    class ConfigsFix {
        public IEmailConfig emailConfig {get;set;}
        public IDatabaseConfig databaseConfig {get;set;}
    }
    interface IEmailConfig {}
    interface IDatabaseConfig {}
}

namespace DEPENDENCY_INVERSION_PRINCIPLE_FIXED
{
    class Configs {
        public IEmailConfig emailConfig {get;set;}
        public IDatabaseConfig databaseConfig {get;set;}
    }

    interface IEmailConfig {}
    interface IDatabaseConfig {}
}
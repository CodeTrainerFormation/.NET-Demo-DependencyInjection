using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Dal
{
    class MyDbInitializer : DropCreateDatabaseAlways<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            context.Persons.AddRange(new List<Person>()
            {
                new Person()
                {
                    FirstName = "Ted",
                    LastName = "Mosby",
                    Age = 35,
                },
                new Person()
                {
                    FirstName = "Barney",
                    LastName = "Stinson",
                    Age = 34,
                },
                new Person()
                {
                    FirstName = "Marshall",
                    LastName = "Eriksen",
                    Age = 36,
                },
                new Person()
                {
                    FirstName = "Robin",
                    LastName = "Scherbatsky",
                    Age = 37,
                },
                new Person()
                {
                    FirstName = "Lily",
                    LastName = "Aldrin",
                    Age = 35,
                },
            });

            base.Seed(context);
        }
    }
}

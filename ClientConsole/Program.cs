using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using DomainModel;
using IRepository;
using Repository;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = InitDependency();


            IPersonRepository context = container.Resolve<IPersonRepository>();

            //LINQ
            var results = context.Persons.Where(p => p.Age > 35).ToList();

            //LINQ (sql like)
            var result = (from p in context.Persons
                         where p.Age > 35
                         select p).ToList();

            foreach (var person in results)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
            
            
            container.Dispose();

            Console.ReadLine();
        }

        private static WindsorContainer InitDependency()
        {
            var container = new WindsorContainer();

            container.Register(Component.For<IPersonRepository>().ImplementedBy<PersonRepository>());

            return container;
        }
    }
}

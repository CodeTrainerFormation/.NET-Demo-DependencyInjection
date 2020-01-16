using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using DomainModel;
using IRepository;

namespace Repository
{
    public class PersonRepository : IPersonRepository
    {
        private MyDbContext context;

        public PersonRepository()
        {
            this.context = new MyDbContext();
        }

        public IQueryable<Person> Persons
        {
            get
            {
                return this.context.Persons.AsQueryable();   
            }
        }
    }
}

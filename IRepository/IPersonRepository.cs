using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace IRepository
{
    public interface IPersonRepository
    {
        IQueryable<Person> Persons { get; }
    }
}

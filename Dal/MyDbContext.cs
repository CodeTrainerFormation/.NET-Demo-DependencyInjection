using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace Dal
{
    public class MyDbContext : DbContext
    {

        public DbSet<Person> Persons { get; set; }

        public MyDbContext()
            : base("DemoDI")
        {
            
        }

        static MyDbContext()
        {
            Database.SetInitializer<MyDbContext>(new MyDbInitializer());
        }
    }
}

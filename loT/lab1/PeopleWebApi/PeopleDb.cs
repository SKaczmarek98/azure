using Microsoft.EntityFrameworkCore;
using PeopleWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleWebApi
{
    public class PeopleDb : DbContext
    {
        public PeopleDb(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}

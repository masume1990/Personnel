using Microsoft.EntityFrameworkCore;
using Personnel.DataLayer.Entitites.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Personnel.DataLayer.Context
{
    public class PersonnelContext:DbContext
    {
        public PersonnelContext(DbContextOptions<PersonnelContext> options):base(options)
        {

        }

        #region User

        public DbSet<Person> People { get; set; }
        #endregion

    }
}

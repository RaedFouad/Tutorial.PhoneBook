using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.PhoneBook.Application.Contracts;
using Tutorial.PhoneBook.Domain.Entities;

namespace Tutorial.PhoneBook.Presistance.Context
{
    public partial class DatabaseService : DbContext, IDataBaseService
    {
        public DatabaseService()
        {
        }
        public DatabaseService(DbContextOptions<DatabaseService> options) : base(options)
        {
        }

        public DbSet<User> Users { get ; set ; }
        public DbSet<PhoneNumber> phoneNumbers { get; set; }
        public DbSet<PhoneNumberType> phoneNumberTypes { get; set; }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=.;InitialCatalog=SQLDPPhoneBook;IntegratedSecurity=true;TrustServerCertificate=True;");
        }
    }
}

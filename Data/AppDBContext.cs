using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zenon___Contact_Management_System.Data
{
    public class AppDBContext : DbContext
    {
        //Set up the configuration with the database
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
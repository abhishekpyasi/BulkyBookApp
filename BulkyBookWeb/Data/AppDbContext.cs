using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBookWeb.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Categorymodel>  Category { get; set; }
        public DbSet<ApplicationType> AppliCationTypes
        { get; set; }

        public DbSet<Item> Items
        { get; set; }



    }
}

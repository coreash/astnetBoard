using aspNetBoard.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspNetBoard.DataContext
{
    //add-migration FirstMigration
    //update-database
    public class AspNetNoteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Data Source = 192.168.35.155,9060; Initial Catalog = coreash; Persist Security Info = True; User ID = sa; Password = dhfpswl1");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}

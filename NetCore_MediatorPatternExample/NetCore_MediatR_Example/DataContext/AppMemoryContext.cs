using Microsoft.EntityFrameworkCore;
using NetCore_MediatR_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_MediatR_Example.Persistence
{
    public class AppMemoryContext : DbContext
    {
        public AppMemoryContext(DbContextOptions<AppMemoryContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<TestObject> TestObjects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestObject>().HasData(
                new TestObject { Id = 1, Name = "Mert" },
                new TestObject { Id = 2, Name = "Mert1" },
                new TestObject { Id = 3, Name = "Mert2" }


                );
            base.OnModelCreating(modelBuilder);
        }
    }


}

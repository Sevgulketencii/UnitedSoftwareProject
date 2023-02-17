using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostApi.DataAccessLayer
{
    public class Dbcontext:DbContext
    {
        public DbSet<Post> PostDbSet { get; set; }
        public DbSet<FoodPost> FoodPostDbSet { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KCH0A99;database=PostApi;integrated security=true");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WishList.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Models.Item> Items { get; set; }
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
    }
}

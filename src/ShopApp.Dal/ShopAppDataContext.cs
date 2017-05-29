using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopApp.Domain;

namespace ShopApp.Dal
{
    public class ShopAppDataContext : DbContext
    {
        public ShopAppDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ListItem> ListItems { get; set; }
        public DbSet<ShopList> ShoppingLists { get; set; }
    }
}

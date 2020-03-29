using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RPGCalendar.Data.Models;

namespace RPGCalendar.Data.EFDataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameObject> Gameobjects { get; set; }

    }
}

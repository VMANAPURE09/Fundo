using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Services.Entity;
using System;
using System.Text;

namespace RepositoryLayer.Services
{
    public class FundooContext : DbContext
    {
        public FundooContext(DbContextOptions<FundooContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}

using contact_manager_dot_net.Models;
using Microsoft.EntityFrameworkCore;

namespace contact_manager_dot_net.Data;

    public class IDbContext : DbContext
    {
        public IDbContext(DbContextOptions<IDbContext> options) : base(options)
        {

        } 
        
        public DbSet<Contact> Contacts { get; set; }

    }


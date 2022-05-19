using contact_manager_dot_net.Models;
using System.Data.Entity;

namespace contact_manager_dot_net.Data
{
    public class ContactContext : DbContext
    {
        public ContactContext()
        {

        }
        public DbSet<DatabaseResponseModel> ContactsAPI { get; set; }
        

    }
}
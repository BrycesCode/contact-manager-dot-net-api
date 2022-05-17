using contact_manager_dot_net.Data;
using Microsoft.AspNetCore.Mvc;

namespace contact_manager_dot_net.Controllers
{
    public class ContactController : Controller
    {
        private readonly IDbContext _db;

        public ContactController(IDbContext db)
        {
            _db = db;
        }
    }
}

using contact_manager_dot_net.Interfaces;
using contact_manager_dot_net.Models;
using Microsoft.AspNetCore.Mvc;

namespace contact_manager_dot_net.Controllers
{
    public class ContactController : Controller
    {
        private readonly IDatabaseServices _databaseServices;

        public ContactController(IDatabaseServices databaseServices)
        {
            _databaseServices = databaseServices;
        }
        [HttpGet("/getContacts")]
        public async Task<IEnumerable<DatabaseResponseModel>> GetContacts()
        {
            try
            {
                return await _databaseServices.GetContacts();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}

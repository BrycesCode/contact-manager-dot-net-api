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
        public async Task<IEnumerable<DatabaseResponseModel>> ContactList()
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
        
        [HttpGet("/getContactFirstName")]
        public async Task<IEnumerable<DatabaseResponseModel>> GetContactFirstName(string firstName)
        {
            try
            {
                return await _databaseServices.GetContactFirstName(firstName);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpPost("/addcontact")]
        public ActionResult AddContact(DatabaseResponseModel databaseModel)
        {
            try
            {
                _databaseServices.InsertContact(databaseModel);
                return Ok();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpPost("/deleteContact/{contactId}")]
        public async Task<ActionResult<string>> DeleteContact(int contactId)
        {
            try
            {
                var response = await _databaseServices.DeleteContact(contactId.ToString());
                return Ok(response);   
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        [HttpPost("/editUser")]

        public async Task<ActionResult> EditContact(DatabaseResponseModel DatabaseUpdateModel)
        {
            try
            {
                await _databaseServices.UpdateField(DatabaseUpdateModel);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}

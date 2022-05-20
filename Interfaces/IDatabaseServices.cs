using contact_manager_dot_net.Models;
using Microsoft.AspNetCore.Mvc;

namespace contact_manager_dot_net.Interfaces
{
    public interface IDatabaseServices
    {
        public Task<IEnumerable<DatabaseResponseModel>> GetContacts();

        public Task<IEnumerable<DatabaseResponseModel>> GetContactFirstName(string firstName);

        public Task<ActionResult<string>> InsertContact(DatabaseResponseModel dbModel);

        public Task<string> DeleteContact(string contactID);

        public Task<string> UpdateField(DatabaseResponseModel updateModel);
    }
}

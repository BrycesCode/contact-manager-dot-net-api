using contact_manager_dot_net.Models;

namespace contact_manager_dot_net.Interfaces
{
    public interface IDatabaseServices
    {
        public Task<IEnumerable<DatabaseResponseModel>> GetContacts();

        public Task<IEnumerable<DatabaseResponseModel>> GetContactFirstName(string firstName);

        public Task<string> InsertContact(DatabaseResponseModel dbModel);

        public Task<string> DeleteContact(string contactID);

        public Task<string> UpdateField(DatabaseResponseModel updateModel);
    }
}

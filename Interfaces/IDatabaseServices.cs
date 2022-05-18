﻿using contact_manager_dot_net.Models;

namespace contact_manager_dot_net.Interfaces
{
    public class IDatabaseServices
    {
        public Task<IEnumerable<DatabaseResponseModel>> GetContacts();

        public Task<IEnumerable<DatabaseResponseModel>> GetContact(string firstName);

        public Task<string> InsertContact(DatabaseResponseModel dbModel);

        public Task<string> DeleteContact(string contactID);

        public Task<string> UpdateField(DatabaseResponseModel updateModel);
    }
}
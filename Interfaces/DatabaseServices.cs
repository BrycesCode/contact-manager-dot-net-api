using contact_manager_dot_net.Models;
using Microsoft.Extensions.Options;
using Microsoft.Data.SqlClient;
using Dapper;


namespace contact_manager_dot_net.Interfaces
{
    public class DatabaseServices : IDatabaseServices
    {
        private readonly IOptions<DatabaseOptions> _dbOptions;

        public DatabaseServices(IOptions<DatabaseOptions> dbOptions)
        {
            _dbOptions = dbOptions;
        }

        public async Task<IEnumerable<DatabaseResponseModel>> GetContacts()
        {
            var queryString = "SELECT * FROM ContactsAPI";
            try
            {
                using var connection = new SqlConnection(_dbOptions.Value.Database);
                IEnumerable<DatabaseResponseModel> response = await connection.QueryAsync<DatabaseResponseModel>(queryString);
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<DatabaseResponseModel>> GetContactFirstName(string firstName)
        {
            var queryString = $"SELECT * FROM ContactsAPI WHERE firstName = '{firstName}'";
            using var connection = new SqlConnection(_dbOptions.Value.Database);
            try
            {
                IEnumerable<DatabaseResponseModel> response = await connection.QueryAsync<DatabaseResponseModel>(queryString);
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public async Task<string> InsertContact(DatabaseResponseModel dbModel)
        {
            var queryString = $"INSERT INTO ContactsAPI (firstName, lastName, Address, Number, Email) VALUES ('{dbModel.firstName}', '{dbModel.lastName}', '{dbModel.Address}', '{dbModel.Number}', '{dbModel.Email}')";
            try
            {
                using var connection = new SqlConnection(_dbOptions.Value.Database);
                IEnumerable<DatabaseResponseModel> response = await connection.QueryAsync<DatabaseResponseModel>(queryString);
                return $"Contact Added";

            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public async Task<string> DeleteContact(string contactID)
        {
            var queryString = $"Delete FROM ContactsAPI WHERE id = {contactID}";
                try
            {
                using var connection = new SqlConnection(_dbOptions.Value.Database);
                await connection.QueryAsync<DatabaseResponseModel>(queryString);
                return "User deleted";
            }
            catch(Exception ex)
            {
                throw;
            }
                
        }
        public async Task<string> UpdateField(DatabaseResponseModel updateModel)
        {
            var getUserString = $"UPDATE FROM ContactsAPI WHERE contactId = {updateModel.Id} SET firstName = '{updateModel.firstName}', lastName = '{updateModel.lastName}', Address = '{updateModel.Address}', Number = '{updateModel.Number}', Email = '{updateModel.Email}' ";
            //var queryString = $"UPDATE ContactsAPI SET firstName = '{updateModel.firstName}', lastName = '{updateModel.lastName}', Address = '{updateModel.Address}', Number = '{updateModel.Number}', Email = '{updateModel.Email}' ";
            try
            {
                using var connection = new SqlConnection(_dbOptions.Value.Database);
                IEnumerable<DatabaseResponseModel> userDataRepsponse = await connection.QueryAsync<DatabaseResponseModel>(getUserString);
               // IEnumerable<DatabaseResponseModel> reponse = await connection.QueryAsync<DatabaseResponseModel>(queryString);
                return $"updated";
            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }
    
}

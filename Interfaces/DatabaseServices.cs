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
            var queryString = "SELECT * FROM Contacts";
            try
            {
                using var connection = new SqlConnection(_dbOptions.Value.DefaultConnection);
                IEnumerable<DatabaseResponseModel> response = await connection.QueryAsync<DatabaseResponseModel>(queryString);
                return response;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<DatabaseResponseModel>> GetContact(string firstName)
        {

        }


    }
    
}

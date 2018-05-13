using System.Collections.Generic;
using Dapper;
using Users.Domain;

namespace Users.Repository
{
    public class UsersRepository : IUsersRepository
    {
        public IEnumerable<User> GetAllUsers()
        {
            var connection = new System.Data.SqlClient.SqlConnection(@"Server=tests-sql-server.database.windows.net;Database=saling-db;User ID=sailing-reader;Password=aaaa123#;Trusted_Connection=False;Encrypt=True;");

            var result = connection.Query<User>("select * from [dbo].[Users]");

            return result;
        }
    }
}

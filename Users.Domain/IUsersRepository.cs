using System.Collections.Generic;

namespace Users.Domain
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetAllUsers();
    }
}
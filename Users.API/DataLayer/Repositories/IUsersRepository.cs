using System.Threading.Tasks;
using System;
using Users.API.DataLayer.Model;

namespace Users.API.DataLayer.Repositories
{
    public interface IUsersRepository
    {
        Task<User> GetUser(Guid id);
        Task CreateUser(User user);
        Task<User> GetUserByEmail(string email);
    }
}
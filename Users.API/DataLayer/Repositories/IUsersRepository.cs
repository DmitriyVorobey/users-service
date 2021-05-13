using User.API.DataLayer.Model;
using System.Threading.Tasks;

namespace User.API.DataLayer.Repositories
{
    public interface IUsersRepository
    {
        Task<UserDto> GetUser(int id);
        Task CreateUser(UserDto user);
    }
}
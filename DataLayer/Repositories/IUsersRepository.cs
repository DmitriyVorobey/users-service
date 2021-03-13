using CQRSUser.DataLayer.Model;
using System.Threading.Tasks;

namespace CQRSUser.DataLayer.Repositories
{
    public interface IUsersRepository
    {
        Task<UserDto> GetUser(int id);
    }
}
using CQRSUser.DataLayer.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSUser.DataLayer.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private List<UserDto> _users = new List<UserDto>()
        {
            new UserDto()
            {
                Id = 1,
                Email = "vasya@gmail.com",
                Address = "Kyiv",
                FirstName = "Vasya",
                LastName = "Oresh",
                PhoneNumber = "044 435 34 44"
            },
            new UserDto()
            {
                Id = 2,
                Email = "oleg@gmail.com",
                Address = "Kyiv",
                FirstName = "Oleg",
                LastName = "Red",
                PhoneNumber = "016 255 05 44"
            }
        };

        public async Task<UserDto> GetUser(int id)
        {
            return await Task.FromResult(_users.FirstOrDefault(x => x.Id == id));
        }
    }
}

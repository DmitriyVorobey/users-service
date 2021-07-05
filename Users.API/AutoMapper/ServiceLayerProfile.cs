using AutoMapper;
using Users.API.DataLayer.Model;
using Users.API.Models;
using Users.API.ServiceLayer.Commands;

namespace Users.API.AutoMapper
{
    public class ServiceLayerProfile : Profile
    {
        public ServiceLayerProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<CreateUserCommand, User>();
        }
    }
}

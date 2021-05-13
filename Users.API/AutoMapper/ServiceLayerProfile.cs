using AutoMapper;
using User.API.DataLayer.Model;
using User.API.Models;
using User.API.ServiceLayer.Commands;

namespace User.API.AutoMapper
{
    public class ServiceLayerProfile : Profile
    {
        public ServiceLayerProfile()
        {
            CreateMap<UserDto, UserViewModel>();
            CreateMap<CreateUserCommand, UserDto>();
        }
    }
}

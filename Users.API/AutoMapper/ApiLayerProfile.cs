using AutoMapper;
using Users.API.Models;
using Users.API.ServiceLayer.Commands;

namespace Users.API.AutoMapper
{
    public class ApiLayerProfile : Profile
    {
        public ApiLayerProfile()
        {
            CreateMap<CreateUserModel, CreateUserCommand>();
        }
    }
}

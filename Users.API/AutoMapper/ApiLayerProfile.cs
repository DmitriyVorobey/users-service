using AutoMapper;
using User.API.Models;
using User.API.ServiceLayer.Commands;

namespace User.API.AutoMapper
{
    public class ApiLayerProfile : Profile
    {
        public ApiLayerProfile()
        {
            CreateMap<CreateUserModel, CreateUserCommand>();
        }
    }
}

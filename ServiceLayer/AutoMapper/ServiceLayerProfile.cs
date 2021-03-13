using AutoMapper;
using CQRSUser.DataLayer.Model;
using CQRSUser.Models;

namespace CQRSUser.ServiceLayer.Mappers
{
    public class ServiceLayerProfile : Profile
    {
        public ServiceLayerProfile()
        {
            CreateMap<UserDto, UserViewModel>();
        }
    }
}

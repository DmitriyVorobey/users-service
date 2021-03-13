using AutoMapper;
using CQRSUser.DataLayer.Model;
using CQRSUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

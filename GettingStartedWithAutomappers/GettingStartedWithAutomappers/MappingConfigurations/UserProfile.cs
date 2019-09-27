using AutoMapper;
using GettingStartedWithAutomappers.Models;
using GettingStartedWithAutomappers.ViewModel;

namespace GettingStartedWithAutomappers.MappingConfigurations
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>();
        }       

    }
}

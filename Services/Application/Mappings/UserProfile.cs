using AutoMapper;
namespace Application.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserProfileResponse>();
            CreateMap<RegisterRequest, User>();
        }
    }
}

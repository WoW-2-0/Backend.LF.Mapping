using AutoMapper;
using ObjectMapping.AutoMapper.Console.Models.Dtos;
using ObjectMapping.AutoMapper.Console.Models.Entities;

namespace ObjectMapping.AutoMapper.Console.Models.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserDto, User>();
        CreateMap<User, UserDto>();
    }
}
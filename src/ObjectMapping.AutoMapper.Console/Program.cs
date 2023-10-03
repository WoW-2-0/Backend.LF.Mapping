using AutoMapper;
using ObjectMapping.AutoMapper.Console.Models.Dtos;
using ObjectMapping.AutoMapper.Console.Models.Entities;

var mapper = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<UserDto, User>();
    cfg.CreateMap<User, UserDto>();
}).CreateMapper();

var john = new User
{
    Id = Guid.NewGuid(),
    FirstName = "John",
    LastName = "Doe",
    EmailAddress = "john.doe@gmail.com",
    Password = "123456",
    CreatedTime = DateTime.UtcNow,
    ModifiedTime = null,
    DeletedTime = null,
    IsDeleted = false
};

var jane = new UserDto
{
    Id = Guid.NewGuid(),
    FirstName = "John",
    LastName = "Doe",
    EmailAddress = "john.doe@gmail.com",
    Password = "123456",
};

var resultA = mapper.Map<UserDto>(john);
var resultB = mapper.Map<User>(jane);

Console.ReadLine();
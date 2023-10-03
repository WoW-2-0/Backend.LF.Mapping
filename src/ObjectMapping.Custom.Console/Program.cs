using ObjectMapping.Custom.Console.Models.Dtos;
using ObjectMapping.Custom.Console.Models.Entities;

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

var resultA = (UserDto)john;
var resultB = (User)jane;

Console.ReadLine();
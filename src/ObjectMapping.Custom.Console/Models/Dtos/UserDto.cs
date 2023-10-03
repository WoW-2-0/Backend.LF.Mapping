using ObjectMapping.Custom.Console.Models.Entities;

namespace ObjectMapping.Custom.Console.Models.Dtos;

public class UserDto
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string EmailAddress { get; set; }

    public string Password { get; set; }

    public static explicit operator User(UserDto userDto)
    {
        return new User
        {
            Id = userDto.Id,
            FirstName = userDto.FirstName,
            LastName = userDto.LastName,
            EmailAddress = userDto.EmailAddress,
            Password = userDto.Password,
            CreatedTime = DateTime.UtcNow,
            ModifiedTime = null,
            DeletedTime = null,
            IsDeleted = false
        };
    }

    public static explicit operator UserDto(User user)
    {
        return new UserDto
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            EmailAddress = user.EmailAddress,
            Password = user.Password
        };
    }
}
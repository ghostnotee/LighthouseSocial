using Domain.Common;

namespace Domain.Entities;

public class User : EntityBase
{
    public string FullName { get; set; }
    public string Email { get; set; }
    protected User() {}

    public User(string fullName, string email)
    {
        FullName = fullName;
        Email = email;
    }
    
    // Photos,
    // Comments,
}

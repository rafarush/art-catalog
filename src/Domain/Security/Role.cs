using Domain.Users;
using SharedKernel;

namespace Domain.Security;

public class Role : Entity
{
    public required string Name { get; set; }
    public required List<Policy> Policies { get; set; } = [];
    public List<User> Users { get; set; }
}

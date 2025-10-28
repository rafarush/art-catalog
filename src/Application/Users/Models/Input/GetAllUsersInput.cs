using Microsoft.AspNetCore.Mvc;
using SharedKernel;

namespace Application.Users.Models.Input;

public class GetAllUsersInput : PaginatedInput
{
    [FromQuery]
    public string? email { get; set; }
    [FromQuery]
    public string? firstName { get; set; }
    [FromQuery]
    public string? lastName { get; set; }
}

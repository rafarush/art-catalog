using Application.Abstractions.Authentication;
using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Application.Users.Models.Output;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using SharedKernel;

namespace Application.Users.GetAllUsers;

internal sealed class GetAllUsersQueryHandler(IApplicationDbContext context)
    : IQueryHandler<GetAllUsersQuery, PaginatedOutput<UserResponse>>
{
    public async Task<Result<PaginatedOutput<UserResponse>>> Handle(GetAllUsersQuery query, CancellationToken cancellationToken)
    {
        List<UserResponse> users = await context.Users
            .Where(x => !x.IsDeleted)
            .Select(user => new UserResponse
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
            })
            .ToListAsync(cancellationToken);
        
        int count =  users.Count;
        
        return Result.Success(new PaginatedOutput<UserResponse>(users.AsEnumerable(), count));
    }
}

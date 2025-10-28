using Application.Abstractions.Messaging;
using Application.Users.GetAllUsers;
using Application.Users.Models.Input;
using Application.Users.Models.Output;
using Microsoft.AspNetCore.Mvc;
using SharedKernel;
using Web.Api.Extensions;
using Web.Api.Infrastructure;

namespace Web.Api.Endpoints.Users;

public sealed class GetAll : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("users/", async (
                [AsParameters] GetAllUsersInput input,
                IQueryHandler<GetAllUsersQuery, PaginatedOutput<UserResponse>> handler,
                CancellationToken cancellationToken) =>
            {
                var query = new GetAllUsersQuery(input);

                Result<PaginatedOutput<UserResponse>> result = await handler.Handle(query, cancellationToken);

                return result.Match(Results.Ok, CustomResults.Problem);
            })
            .WithTags(Tags.Users);
    }
}

using Application.Abstractions.Messaging;
using Application.Users.Models.Input;
using Application.Users.Models.Output;
using SharedKernel;

namespace Application.Users.GetAllUsers;

public sealed record GetAllUsersQuery(GetAllUsersInput Input) : IQuery<PaginatedOutput<UserResponse>>;

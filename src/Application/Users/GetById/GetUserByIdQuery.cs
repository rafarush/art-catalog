﻿using Application.Abstractions.Messaging;
using Application.Users.Models.Output;

namespace Application.Users.GetById;

public sealed record GetUserByIdQuery(Guid UserId) : IQuery<UserResponse>;

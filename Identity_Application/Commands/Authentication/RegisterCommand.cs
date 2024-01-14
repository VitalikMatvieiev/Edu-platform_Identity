﻿using Identity_Application.Interfaces.Authentication;
using Identity_Application.Models.AuthorizationModels;
using MediatR;

namespace Identity_Application.Commands.Authentication;

public record RegisterCommand(RegisterVM RegisterVM) : IRequest<string>;

public class RegisterHandler : IRequestHandler<RegisterCommand, string>
{
    private readonly IAuthenticationService _authenticationService;

    public RegisterHandler(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    public async Task<string> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        if (request.RegisterVM is null)
            throw new ArgumentNullException("Given data is not correct");

        var token = await _authenticationService
            .Register(request.RegisterVM.Username, request.RegisterVM.Email, request.RegisterVM.Password);

        return token;
    }
}
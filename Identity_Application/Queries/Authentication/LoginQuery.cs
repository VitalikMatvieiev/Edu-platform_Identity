﻿using FluentValidation;
using Identity_Application.Helpers.Validators;
using Identity_Application.Interfaces.Authentication;
using Identity_Application.Models.AuthorizationModels;
using MediatR;

namespace Identity_Application.Queries.Authentication;

public record LoginQuery(LoginVM LoginVM) : IRequest<string>;

public class LoginHandler : IRequestHandler<LoginQuery, string>
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IValidator<LoginVM> _validator;

    public LoginHandler(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
        _validator = new LoginValidator();
    }

    public async Task<string> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        if (request.LoginVM is null)
            throw new ArgumentNullException("Provided login data was incorrect");

        var errors = _validator.Validate(request.LoginVM);

        foreach (var error in errors.Errors)
        {
            throw new Exception(error.ErrorMessage);
        }

        string token;

        try
        {
            token = await _authenticationService
            .Login(request.LoginVM.Email, request.LoginVM.Password);
        }
        catch (Exception ex)
        {
            throw new Exception($"Registration exception occured: {ex.Message}", ex);
        }

        return token;
    }
}
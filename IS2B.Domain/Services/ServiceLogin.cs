using IS2B.Domain.Arguments.Login;
using IS2B.Domain.Entities;
using IS2B.Domain.Interfaces.Repositories;
using IS2B.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS2B.Domain.Services
{
    public class ServiceLogin : IServiceLogin
    {
        private readonly IRepositoryLogin _repositoryLogin;

        public ServiceLogin(IRepositoryLogin repositoryLogin)
        {
            _repositoryLogin = repositoryLogin;
        }

        public TokenResponse GetToken(GetTokenRequest credentialsLogin)
        {
            JsonLoginRequest jsonLoginRequest = new JsonLoginRequest(credentialsLogin.ClientId, credentialsLogin.ClientSecret, credentialsLogin.GrantType);

            jsonLoginRequest = _repositoryLogin.GetToken(jsonLoginRequest);

            TokenResponse response = new TokenResponse();

            return response;



        }

    }
}

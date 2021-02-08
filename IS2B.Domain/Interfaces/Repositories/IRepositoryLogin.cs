using IS2B.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS2B.Domain.Interfaces.Repositories
{
    public interface IRepositoryLogin
    {
        JsonLoginRequest GetToken(JsonLoginRequest jsonLoginRequest);
    }
}

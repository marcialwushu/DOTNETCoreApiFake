using IS2B.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS2B.Domain.Entities
{
    public class Login : EntityBase
    {
        public Login() { }

        public string ClientSecret { get; set; }
        public string ClientId { get; set; }
        public string GrantType { get; set; }
    }
}

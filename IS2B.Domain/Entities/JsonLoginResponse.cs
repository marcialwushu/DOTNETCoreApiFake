using IS2B.Domain.Entities.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS2B.Domain.Entities
{
    class JsonLoginResponse : EntityBase
    {
        public JsonLoginResponse() { }

        [JsonProperty("access_token")]
        public string AcessToken { get; set; }

        [JsonProperty("expires_in")]
        public string ExpiresIn { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        public static explicit operator JsonLoginResponse(JsonLoginRequest v)
        {
            throw new NotImplementedException();
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS2B.Domain.Arguments.Login
{
    public class TokenResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }
}

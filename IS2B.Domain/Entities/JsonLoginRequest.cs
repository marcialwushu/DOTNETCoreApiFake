using IS2B.Domain.Entities.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IS2B.Domain.Entities
{
    public class JsonLoginRequest 
    {
        public JsonLoginRequest() { }

        public JsonLoginRequest(string clientId, string clientSecret, string grantType)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            GrantType = grantType;
        }

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("grant_type")]
        public string GrantType { get; set; }
    }
}

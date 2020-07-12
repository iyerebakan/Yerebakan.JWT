using System;
using System.Collections.Generic;
using System.Text;

namespace Yerebakan.JWT.Core.Models
{
    public class TokenOptions
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}

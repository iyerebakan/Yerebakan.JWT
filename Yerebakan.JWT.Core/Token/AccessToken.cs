using System;

namespace Yerebakan.JWT.Token
{
    public class AccessToken : TokenInfo
    {
        public AccessToken(TokenInfo tokenInfo)
        {
            Email = tokenInfo.Email;
            Id = tokenInfo.Id;
            Roles = tokenInfo.Roles;
            UserName = tokenInfo.UserName;
        }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}

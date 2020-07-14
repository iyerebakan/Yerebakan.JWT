using Yerebakan.JWT.Core.Models;
using Yerebakan.JWT.Core.Services.Encryption;
using Yerebakan.JWT.Services.Jwt;
using Yerebakan.JWT.Token;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Yerebakan.JWT.DependencyInjection
{
    public static class JWTDependencyInjection
    {
        public static void AddYerebakanJWT(this IServiceCollection services, TokenOptions token)
        {
            services.AddSingleton<ITokenHelper, JwtService>();

            var tokenOptions = token;
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidAudience = tokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
                    };
                });
        }
    }
}

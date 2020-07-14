using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yerebakan.JWT.Token;

namespace Yerebakan.JWT.Core.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ITokenHelper _tokenHelper;
        public TokenController(ITokenHelper tokenHelper)
        {
            _tokenHelper = tokenHelper;
        }

        [HttpPost]
        public IActionResult Get(TokenInfo tokenInfo)
        {
            var accessToken = _tokenHelper.CreateToken(tokenInfo);
            return Ok(accessToken);
        }
    }
}

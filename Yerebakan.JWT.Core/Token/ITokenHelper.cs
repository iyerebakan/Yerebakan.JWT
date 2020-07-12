namespace Yerebakan.JWT.Token
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(TokenInfo tokenInfo);
    }
}

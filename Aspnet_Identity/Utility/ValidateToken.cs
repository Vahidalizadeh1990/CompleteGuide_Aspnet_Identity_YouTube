using System.IdentityModel.Tokens.Jwt;

namespace Aspnet_Identity.Utility
{
    // All token that are comming from the external providers should be decoded 
    // This class is responsible for decoding the external providers 
    // Google has been set and based on the iss value, we can split other external providers like facebook or microsoft
    public static class ValidateToken
    {
        public static string Authenticate(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token);
            var _token = jsonToken as JwtSecurityToken;
            var iss = _token.Claims.First(claim => claim.Type == "iss").Value;
            if(iss == "accounts.google.com")
            {
                var email = _token.Claims.First(claim => claim.Type == "email").Value;
                return email;
            }
            return null;
        }
    }
}

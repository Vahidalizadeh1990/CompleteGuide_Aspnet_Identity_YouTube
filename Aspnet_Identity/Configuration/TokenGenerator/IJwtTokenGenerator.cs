using Microsoft.AspNetCore.Identity;

namespace Aspnet_Identity.Configuration.TokenGenerator
{
    // This interface is responsible for generating a new jwt token
    public interface IJwtTokenGenerator
    {
        string GenerateToken(IdentityUser user);
    }
}

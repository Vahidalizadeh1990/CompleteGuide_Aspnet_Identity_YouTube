namespace Aspnet_Identity.Configuration
{
    // This class is going to set all information inside the appsettings.json file to the Program.cs file
    public class JwtSettings
    {
        public const string SectionName = "JwtSettings";
        public string Secret { get; init; } = null!;
        public int ExpiryMinutes { get; init; }
        public string Issuer { get; set; } = null!;
        public string Audience { get; set; } = null!;
    }
}

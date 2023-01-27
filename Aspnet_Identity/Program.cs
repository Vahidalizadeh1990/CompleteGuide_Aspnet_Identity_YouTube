using Aspnet_Identity.Configuration;
using Aspnet_Identity.Configuration.EmailSender;
using Aspnet_Identity.Configuration.TokenGenerator;
using Aspnet_Identity.Models;    
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

#region Connection to the Database
var connectionString = builder.Configuration.GetConnectionString("DbConnection");

// Register AppDbContext
builder.Services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(connectionString));
#endregion
#region AspNetIdentity
// Register AspNetIdentity
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedEmail = true;
    // After 5 request failed the account will be locked
    options.Lockout.MaxFailedAccessAttempts = 5;
    
    // After 5 minutes the account will be unlocked
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
}).AddEntityFrameworkStores<AppDbContext>().AddRoles<IdentityRole>().AddDefaultTokenProviders();
#endregion 
#region Cookie Policy
//Cookie Policy needed for External Auth
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.Unspecified;
});
#endregion
builder.Services.AddCors();
#region Email Configuration
// Email Configuration
var emailSettings = new EmailSettings();
builder.Configuration.Bind(EmailSettings.SectionName, emailSettings);
builder.Services.AddSingleton(Options.Create(emailSettings));
builder.Services.AddSingleton<IMailService, MailService>();
#endregion
#region JWT
// Jwt Configuration
var jwtSettings = new JwtSettings();
builder.Configuration.Bind(JwtSettings.SectionName, jwtSettings);

builder.Services.AddSingleton(Options.Create(jwtSettings));

builder.Services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(
    options => options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings.Issuer,
        ValidAudience = jwtSettings.Audience,
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(jwtSettings.Secret))
    });
#endregion

var app = builder.Build();

// CORS
app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithOrigins("http://localhost:3000/")
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials());

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

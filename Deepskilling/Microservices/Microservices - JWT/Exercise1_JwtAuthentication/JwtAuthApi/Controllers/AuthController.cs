using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtAuthApi.Models;

namespace JwtAuthApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    // TODO: move this to config later
    private const string SecretKey = "ThisIsASecretKeyForJwtToken";

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginModel model)
    {
        if (!IsValidUser(model))
            return Unauthorized();

        var token = GenerateJwtToken(model.Username);
        return Ok(new { Token = token });
    }

    [Authorize]
    [HttpGet("secure")]
    public IActionResult SecureEndpoint()
    {
        var username = User.Identity!.Name;
        return Ok(new { Message = $"Hello {username}, you are authenticated!" });
    }

    private bool IsValidUser(LoginModel model)
    {
        // hardcoded for now, ideally this checks a db
        return model.Username == "admin" && model.Password == "password";
    }

    private string GenerateJwtToken(string username)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, username)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: "MyAuthServer",
            audience: "MyApiUsers",
            claims: claims,
            expires: DateTime.Now.AddMinutes(60),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}

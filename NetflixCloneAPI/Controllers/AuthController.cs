﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.DTO;
using System.Security.Claims;
using System.Security.Cryptography;

namespace NetflixCloneAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AuthController : Controller
    {
        [HttpPost("register")]
        [AllowAnonymous]
        public IActionResult Register(CreateUserDTO request)
        {
            User user = new()
            {
                Id = Guid.NewGuid(),
                Email = request.Email
            };

            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            return Ok(request);
        }
        //public async Task<ActionResult> Register(NewUserDto request)
        //{
        //    var user = _context.Users.FirstOrDefault(user => user.Username.Equals(request.Username));

        //    if (user != null)
        //    {
        //        return BadRequest("That username is already taken.");
        //    }

        //    CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

        //    User newUser = new()
        //    {
        //        Id = new Guid(),
        //        Username = request.Username,
        //        Email = request.Email,
        //        PhoneNumber = request.PhoneNumber,
        //        PasswordHash = passwordHash,
        //        PasswordSalt = passwordSalt,
        //        AuthType = "Email"
        //    };

        //    await _context.AddAsync(newUser);
        //    await _context.SaveChangesAsync();

        //    ReturnUserDto returnUser = new()
        //    {
        //        Uid = newUser.Id.ToString(),
        //        Username = newUser.Username,
        //        Email = newUser.Email,
        //        Role = newUser.Role,
        //        AccessToken = ""
        //    };

        //    return Ok(returnUser);
        //}

        static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            var hmac = new HMACSHA256();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }

        static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            var hmac = new HMACSHA256(passwordSalt);
            var hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return hash.SequenceEqual(passwordHash);
        }

        //static string CreateToken(User user)
        //{
        //    List<Claim> claims = new()
        //    {
        //        new Claim("id", user.Id.ToString()),
        //        new Claim("username", user.Username),
        //        new Claim("email", user.Email),
        //        new Claim(ClaimTypes.Role, user.Role),
        //    };

        //    var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));
        //    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
        //    var token = new JwtSecurityToken(
        //        claims: claims,
        //        expires: DateTime.Now.AddHours(1),
        //        signingCredentials: creds
        //    );

        //    var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        //    return jwt;
        //}

        //static RefreshToken GenerateRefreshToken()
        //{
        //    RefreshToken refreshToken = new()
        //    {
        //        Token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
        //        Created = DateTime.Now,
        //        Expires = DateTime.Now.AddDays(30)
        //    };

        //    return refreshToken;
        //}

        //private void SetRefreshToken(User user, RefreshToken newRefreshToken)
        //{
        //    CookieOptions cookieOptions = new()
        //    {
        //        HttpOnly = true,
        //        Expires = newRefreshToken.Expires
        //    };

        //    //Response.Cookies.Delete("refreshToken");
        //    Response.Cookies.Append("refreshToken", newRefreshToken.Token, cookieOptions);

        //    user.RefreshToken = newRefreshToken.Token;
        //    user.TokenCreated = newRefreshToken.Created;
        //    user.TokenExpires = newRefreshToken.Expires;

        //    _context.Update(user);
        //    _context.SaveChanges();
        //}
    }
}
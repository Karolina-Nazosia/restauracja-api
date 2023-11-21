using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RestaurantAPI.Models;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;

namespace RestaurantAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class LoginController : ControllerBase
    //{
    //    [HttpPost, Route("login")]
    //    public IActionResult Login(LoginDto loginDTO)
    //    {
    //        try
    //        {
    //            if (string.IsNullOrEmpty(loginDTO.Email) ||
    //            string.IsNullOrEmpty(loginDTO.Password))
    //                return BadRequest("Username and/or Password not specified");
    //            if (loginDTO.Email.Equals("test") &&
    //            loginDTO.Password.Equals("test"))
    //            {
    //                var secretKey = new SymmetricSecurityKey
    //                (Encoding.UTF8.GetBytes("thisisasecretkey@123"));
    //                var signinCredentials = new SigningCredentials
    //               (secretKey, SecurityAlgorithms.HmacSha256);
    //                var jwtSecurityToken = new JwtSecurityToken(
    //                    issuer: "ABCXYZ",
    //                    audience: "http://localhost:5000",
    //                    claims: new List<Claim>(),
    //                    expires: DateTime.Now.AddMinutes(10),
    //                    signingCredentials: signinCredentials
    //                );
    //                Ok(new JwtSecurityTokenHandler().
    //                WriteToken(jwtSecurityToken));
    //            }
    //        }
    //        catch
    //        {
    //            return BadRequest
    //            ("An error occurred in generating the token");
    //        }
    //        return Unauthorized();
    //    }
    //}
}

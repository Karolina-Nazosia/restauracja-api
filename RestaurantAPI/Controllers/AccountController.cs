using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RestaurantAPI.Models;
using RestaurantAPI.Services;

namespace RestaurantAPI.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpPost("register"), Authorize]
        public ActionResult RegisterUser([FromBody] RegisterUserDto dto)
        {
            _accountService.RegisterUser(dto);
            return Ok();
        }

        [HttpPost("login")]
        public ActionResult Login([FromBody] LoginDto dto)
        {
            string token = _accountService.GenerateJwt(dto);
            return Ok(token);

        }

        //public ActionResult<IEnumerable<RegisterUserDto>> GetAll([FromQuery] RegisterUserDto query)
        //{
        //    var restaurantsDtos = query.GetAll(query);

        //    return Ok(restaurantsDtos);
        //}
        //[HttpPost, Route("login")]
        //public IActionResult Login([FromBody] LoginDto loginDTO)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(loginDTO.Email) ||
        //        string.IsNullOrEmpty(loginDTO.Password))
        //            return BadRequest("Username and/or Password not specified");
        //        if (loginDTO.Email.Equals("test@test") &&
        //        loginDTO.Password.Equals("test")) 
        //        {
        //            string token = _accountService.GenerateJwt(loginDTO);
        //            return Ok(token);
        //        }
        //    }
        //    catch
        //    {
        //        return BadRequest
        //        ("An error occurred in generating the token");
        //    }
        //    return Unauthorized();
        //}
    }
}
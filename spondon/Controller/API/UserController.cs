using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace spondon.Controller.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [AllowAnonymous]
        [Route("/register")]
        public async Task<IActionResult> RegisterPatient(int x)
        {
            try
            {
                var result = x;

            }
            catch (Exception ex)
            {

            }

            return Ok("hello world");
        }
    }
}
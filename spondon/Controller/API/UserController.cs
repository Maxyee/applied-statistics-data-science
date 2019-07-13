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


        // [HttpGet("register/{x}")]
        // //[AllowAnonymous]
        // //[Route("register/{x}")]
        // public ActionResult<IEnumerable<string>> TestingApi(int x)
        // {
        //     try
        //     {
        //         int result = x;
        //         return x;
        //     }
        //     catch (Exception ex)
        //     {
        //         return ex;
        //     }

        //     //return Ok("hello world");
        // }

        [HttpGet("register/{x}")]
        public ActionResult<string> Fuck(int x)
        {
            int fuckX = x;
            String fuckConvert = x.ToString();
            return fuckConvert ;
            //return new string[] {"fuck calling","fucking value"};
        } 


        //GET api/user
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"value1","value2"};
        } 


        //GET api/user/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }


}
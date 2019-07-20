using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using spondon.Domins;
using spondon.Models;
using spondon.Utilities;

namespace spondon.Controller.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public UserController(
            IMapper mapper,
            ILogger<UserController> logger
            )
        {
            _mapper = mapper;
            _logger = logger;
        }

        [HttpPut("register/")]
        public IActionResult SaveRegistration([FromBody] RegisterViewModel registerViewModel)
        {
            ResponseModel<object> response = new ResponseModel<object>();

            _logger.LogDebug("Entered PUT api/user/register - {0}", registerViewModel.ToString());

            try
            {
                var dtUser = _mapper.Map<RegisterViewModel, User>(registerViewModel);
                response.CreateSuccessResponse(dtUser, "user found");
            }
            catch(Exception ex)
            {
                response.Message = ex.Message;
                _logger.LogError(LoggingEvents.GetItemNotFound, ex, ex.Message);
            }

            _logger.LogDebug("Exiting PUT api/user/register - {0}", registerViewModel.ToString());
            return Ok(response.ValidateResponse());
        }
    }
}
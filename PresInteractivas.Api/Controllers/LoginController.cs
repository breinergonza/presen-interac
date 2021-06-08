using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;
using PresInteractivas.Api.BL;
using PresInteractivas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresInteractivas.Api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly LoginBL _login = new LoginBL();
        private readonly ILogger<LoginController> _logger;

        // The Web API will only accept tokens 1) for users, and 2) having the "access_as_user" scope for this API
        static readonly string[] scopeRequiredByApi = new string[] { "access_as_user" };

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Metodo para autenticar un usuario
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost("Auth")]
        public ActionResult<LoginDto> Auth(LoginDto data)
        {
            bool success = false;
            try
            {
                success = _login.Auth(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);               
            }
            
            //HttpContext.VerifyUserHasAnyAcceptedScope(scopeRequiredByApi);

            var resp = new {
                sucess = success,
                data = data
            };

            return Ok(resp);
            
        }
    }
}

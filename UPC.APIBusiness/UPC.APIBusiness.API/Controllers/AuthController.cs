
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DBContext;
using API;
using UPC.APIBusiness.API.Model;

namespace UPC.APIBusiness.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    [Route("api/auth")]
    public class AuthController : Controller
    {

        /// <summary>
        /// Constructor
        /// </summary>
        protected readonly IUserRepository _UserRepository;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserRepository"></param>
        public AuthController(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;

        }

        /// <summary>
        /// Login
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [Produces("application/json")]
        [ProducesResponseType(201, Type = typeof(LoginResponse))]
        [ProducesResponseType(400, Type = typeof(CustomErrorException))]
        [ProducesResponseType(500, Type = typeof(CustomErrorException))]
        [Route("login")]
        public ActionResult Login(
            [FromBody] LoginRequest req)
        {
            var euser = _UserRepository.Login(req.Login, req.Clave);

            var usuarioresponsedata = AuthMapper.Mapper.Map<UsuarioResponseData>(euser);

            var response = new LoginResponse
            {
                Usuario = usuarioresponsedata
            };

            return Json(response);
        }

    }
}

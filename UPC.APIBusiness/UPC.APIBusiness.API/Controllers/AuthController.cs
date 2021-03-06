
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DBContext;
using API;
using UPC.APIBusiness.API.Model;
using Newtonsoft.Json;
using UPC.E31A.APIBusiness.API.Security;
using System.Threading.Tasks;

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
        [ProducesResponseType(200, Type = typeof(LoginResponse))]
        [ProducesResponseType(400, Type = typeof(CustomErrorException))]
        [ProducesResponseType(500, Type = typeof(CustomErrorException))]
        [Route("login")]
        public async Task<ActionResult> Login(
            [FromBody] LoginRequest req)
        {
            var euser = _UserRepository.Login(req.Login, req.Clave);

            var usuarioresponsedata = AuthMapper.Mapper.Map<UsuarioResponseData>(euser);

            var token = JsonConvert
                                .DeserializeObject<AccessToken>(
                                    await new Authentication()
                                    .GenerateToken(usuarioresponsedata.Profile.Id.ToString(), usuarioresponsedata.Id.ToString())
                                    ).access_token;

            var response = new LoginResponse
            {
                Token = token,
                Usuario = usuarioresponsedata
            };

            Response.Headers.Add("Access-Control-Expose-Headers", "Authorization");
            Response.Headers.Add("Authorization", "Bearer " + token);

            return Json(response);
        }

    }
}

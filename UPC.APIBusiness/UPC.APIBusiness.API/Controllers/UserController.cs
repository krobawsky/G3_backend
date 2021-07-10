using API;
using DBContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UPC.APIBusiness.API.Model;
using System.Security.Claims;
using System.Linq;

namespace UPC.Business.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    [Route("api/user")]
    public class UserController : Controller
    {

        /// <summary>
        /// Constructor
        /// </summary>
        protected readonly IUserRepository _UserRepository;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserRepository"></param>
        public UserController(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;

        }

        /// <summary>
        /// GetListUser
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(ObtenerSidebarResponse))]
        [ProducesResponseType(400, Type = typeof(CustomErrorException))]
        [ProducesResponseType(500, Type = typeof(CustomErrorException))]
        [Route("sidebar")]
        public ActionResult ObtenerSidebar()
        {
            var identity = User.Identity as ClaimsIdentity;
            IEnumerable<Claim> claims = identity.Claims;

            var perfilId = claims.Where(p => p.Type == "client_numero_documento").FirstOrDefault()?.Value;

            var sidebars = _UserRepository.ObtenerSidebar(int.Parse(perfilId));
            var sidebarResponses = AuthMapper.Mapper.Map<List<SidebarResponseData>>(sidebars);

            var response = new ObtenerSidebarResponse
            {
                opciones = sidebarResponses
            };

            return Json(response);
        }

        /// <summary>
        /// GetListUser
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(ObtenerUserProfileResponse))]
        [ProducesResponseType(400, Type = typeof(CustomErrorException))]
        [ProducesResponseType(500, Type = typeof(CustomErrorException))]
        [Route("profile")]
        public ActionResult ObtenerUserProfile()
        {

            var identity = User.Identity as ClaimsIdentity;
            IEnumerable<Claim> claims = identity.Claims;

            var iduser = claims.Where(p => p.Type == "client_codigo_usuario").FirstOrDefault()?.Value;

            var profile = _UserRepository.ObtenerUserProfile(int.Parse(iduser));
            var userProfileResponse = AuthMapper.Mapper.Map<UserProfileResponseData>(profile);

            var response = new ObtenerUserProfileResponse
            {
                user_profile = userProfileResponse
            };

            return Json(response);
        }
    }
}
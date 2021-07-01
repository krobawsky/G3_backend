using API;
using DBContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UPC.APIBusiness.API.Model;

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
        [AllowAnonymous]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(ObtenerSidebarResponse))]
        [ProducesResponseType(400, Type = typeof(CustomErrorException))]
        [ProducesResponseType(500, Type = typeof(CustomErrorException))]
        [Route("sidebar/{idprofile}")]
        public ActionResult ObtenerSidebar(
            int idprofile)
        {
            var sidebars = _UserRepository.ObtenerSidebar(idprofile);
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
        [AllowAnonymous]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(ObtenerUserProfileResponse))]
        [ProducesResponseType(400, Type = typeof(CustomErrorException))]
        [ProducesResponseType(500, Type = typeof(CustomErrorException))]
        [Route("profile/{iduser}")]
        public ActionResult ObtenerUserProfile(
            int iduser)
        {
            var profile = _UserRepository.ObtenerUserProfile(iduser);
            var userProfileResponse = AuthMapper.Mapper.Map<UserProfileResponseData>(profile);

            var response = new ObtenerUserProfileResponse
            {
                user_profile = userProfileResponse
            };

            return Json(response);
        }
    }
}
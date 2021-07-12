using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using API;
using DBContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UPC.APIBusiness.API.Model;
using static UPC.APIBusiness.API.Model.Compro;

namespace UPC.APIBusiness.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    [Route("api/comprobante")]
    public class ComprobanteController : Controller
    {
        /// <summary>
        /// </summary>
        protected readonly IComproRepository _comproRepository;


        /// <summary>
        /// Constructor
        /// </summary>
        public ComprobanteController(IComproRepository comproRepository)
        {
            _comproRepository = comproRepository;
        }

        /// <summary>
        /// lista
        /// </summary>
        [HttpGet]
        [Authorize]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(ComproListResponse))]
        [ProducesResponseType(400, Type = typeof(CustomErrorException))]
        [ProducesResponseType(500, Type = typeof(CustomErrorException))]
        [Route("lista/ruc")]
        public ActionResult ObtenerComproByRuc([FromQuery] string ruc)
        {


            var compros = _comproRepository.getComproByRuc(ruc);
            var comproResponse = AuthMapper.Mapper.Map<List<ComproResponseData>>(compros);
            var response = new ComproListResponse
            {
                comprobantes = comproResponse
            };

            return Json(response);
        }

        /// <summary>
        /// lista
        /// </summary>
        [HttpGet]
        [Authorize]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(ComproListResponse))]
        [ProducesResponseType(400, Type = typeof(CustomErrorException))]
        [ProducesResponseType(500, Type = typeof(CustomErrorException))]
        [Route("lista/date")]
        public ActionResult ObtenerComproByDate([FromQuery] string date)
        {


            var compros = _comproRepository.getComproByDate(date);
            var comproResponse = AuthMapper.Mapper.Map<List<ComproResponseData>>(compros);
            var response = new ComproListResponse
            {
                comprobantes = comproResponse
            };

            return Json(response);
        }
    }
}

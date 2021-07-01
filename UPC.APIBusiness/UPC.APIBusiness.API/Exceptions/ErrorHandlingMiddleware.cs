using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UPC.APIBusiness.API.Constantes;
using UPC.APIBusiness.API.Exceptions;

namespace API
{
    /// <summary>
    /// ErrorHandlingMiddleware
    /// </summary>
    public class ErrorHandlingMiddleware : ExceptionFilterAttribute
    {
        private readonly RequestDelegate next;

        /// <summary>
        /// ErrorHandlingMiddleware constructor
        /// </summary>
        /// <param name="next"></param>
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        /// <summary>
        /// Task Invoke
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        /// <summary>
        /// HandleExceptionAsync
        /// </summary>
        /// <param name="context"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var exceptioncontent = ex.Message;
            var arrexcepcion = exceptioncontent.Split("|");
            string exceptionCodigo;
            string exceptionMensaje;

            exceptionCodigo = arrexcepcion.Length == 1 ? ConstantesError.ERROR_NO_CONTROLADO_CODIGO : arrexcepcion[0];
            exceptionMensaje = arrexcepcion.Length == 1 ? ex.Message : arrexcepcion[1];

            //int code = (int)HttpStatusCode.InternalServerError;

            //if (ex is NotFoundException) code = (int)HttpStatusCode.NotFound;
            //else if (ex is UnauthorizedException) code = (int)HttpStatusCode.Unauthorized;
            //else if (ex is BadRequestException) code = (int)HttpStatusCode.BadRequest;

            ErroresControl.ManejarErrores(exceptionCodigo, out HttpStatusCode httpstatuscode, out string titulo);

            var result = JsonConvert.SerializeObject(
                new CustomErrorException()
                {
                    ErrorCode = exceptionCodigo,
                    Message = exceptionMensaje,
                    Title = titulo,
                    //Details = new Detail()
                    //{
                    //    Code = ex.HResult.ToString(),
                    //    Stack = ex.StackTrace,
                    //    Object = ex.GetType().ToString()
                    //}
                });

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)httpstatuscode;
            return context.Response.WriteAsync(result);
        }
    }
}

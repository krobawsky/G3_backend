using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UPC.APIBusiness.API.Model
{

    #region request

    /// <summary>
    /// AuthUsuarioRequest
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Parametro de login
        /// </summary>
        [JsonProperty("login")]
        public string Login { get; set; }

        /// <summary>
        /// Parametro de clave
        /// </summary>
        [JsonProperty("clave")]
        public string Clave { get; set; }
    }

    #endregion

    #region response

    /// <summary>
    /// LoginResponse
    /// </summary>
    public class LoginResponse
    {
        /// <summary>
        /// usuario
        /// </summary>
        [JsonProperty("usuario")]
        public UsuarioResponseData Usuario { get; set; }
    }

    /// <summary>
    /// ObtenerSidebarResponse
    /// </summary>
    public class ObtenerSidebarResponse
    {
        /// <summary>
        /// opciones
        /// </summary>
        [JsonProperty("opciones")]
        public List<SidebarResponseData> opciones { get; set; }
    }

    /// <summary>
    /// ObtenerUserProfileResponse
    /// </summary>
    public class ObtenerUserProfileResponse
    {
        /// <summary>
        /// user_profile
        /// </summary>
        [JsonProperty("user_profile")]
        public UserProfileResponseData user_profile { get; set; }
    }

    #endregion

    #region models

    /// <summary>
    /// UsuarioResponseData
    /// </summary>
    public class UsuarioResponseData
    {
        /// <summary>
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("nombre_completo")]
        public string NombreUsuario { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("nombres")]
        public string Nombres { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("apellidos")]
        public string Apellidos { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("correo")]
        public string Correo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("profile")]
        public ProfileResponseData Profile { get; set; }

    }

    /// <summary>
    /// ProfileResponseData
    /// </summary>
    public class ProfileResponseData
    {
        /// <summary>
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }
    }

    /// <summary>
    /// UserProfileResponseData
    /// </summary>
    public class UserProfileResponseData
    {
        /// <summary>
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("ruc")]
        public string Ruc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("razon_social")]
        public string RazonSocial { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("departamento")]
        public string Departamento { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("provincia")]
        public string Provincia { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("distrito")]
        public string Distrito { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("direccion")]
        public string Direccion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("telefono")]
        public string Telefono { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("celular")]
        public string Celular { get; set; }
    }

    /// <summary>
    /// UserProfileResponseData
    /// </summary>
    public class SidebarResponseData
    {
        /// <summary>
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("class")]
        public string Class { get; set; }

    }

    #endregion 
}

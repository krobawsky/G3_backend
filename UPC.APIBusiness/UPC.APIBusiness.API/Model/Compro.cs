using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UPC.APIBusiness.API.Model
{
    public class Compro
    {


        #region response

        /// <summary>
        /// LoginResponse
        /// </summary>
        public class ComproListResponse
        {
            /// <summary>
            /// usuario
            /// </summary>
            [JsonProperty("comprobantes")]
            public List<ComproResponseData> comprobantes { get; set; }
        }

        #endregion

        #region models

        /// <summary>
        /// UsuarioResponseData
        /// </summary>
        public class ComproResponseData
        {

            /// <summary>
            /// </summary>
            [JsonProperty("razonsocialemisor")]
            public string razonSocialAdquiriente { get; set; }

            /// <summary>
            /// </summary>
            [JsonProperty("numerodocumentoadquiriente")]
            public string numeroDocumentoAdquiriente { get; set; }

            /// <summary>
            /// </summary>
            [JsonProperty("tipodocumento")]
            public string tipoDocumento { get; set; }

            /// <summary>
            /// </summary>
            [JsonProperty("serienumero")]
            public string serieNumero { get; set; }

            /// <summary>
            /// </summary>
            [JsonProperty("tipomoneda")]
            public string tipoMoneda { get; set; }

            /// <summary>
            /// </summary>
            [JsonProperty("totalventa")]
            public string totalVenta { get; set; }

            /// <summary>
            /// </summary>
            [JsonProperty("fechaemision")]
            public string fechaEmision { get; set; }

            /// <summary>
            /// </summary>
            [JsonProperty("rutadocumento")]
            public string rutaDocumento { get; set; }
        }

        #endregion
    }
}

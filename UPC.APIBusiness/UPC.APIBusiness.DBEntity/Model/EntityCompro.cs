using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class EntityCompro : EntityBase
    {

        public string razonSocialAdquiriente { get; set; }
        public string numeroDocumentoAdquiriente { get; set; }
        public string tipoDocumento { get; set; }
        public string serieNumero { get; set; }
        public string tipoMoneda { get; set; }
        public string totalVenta { get; set; }
        public string fechaEmision { get; set; }
        public string rutaDocumento { get; set; }

    }
}

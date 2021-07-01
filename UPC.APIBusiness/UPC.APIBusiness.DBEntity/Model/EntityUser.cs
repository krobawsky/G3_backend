using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class EntityUser : EntityBase
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public byte[] ContraseniaEncriptada { get; set; }

        public int IdProfile { get; set; }
        public EntityProfile Profile { get; set; }

        //public string Documento { get; set; }
        //public DateTime FechaUltimoAcceso { get; set; }
        //public DateTime FechaInactivo { get; set; }
        //public string TipoAcceso { get; set; }
        //public int NroIntento { get; set; }
        //public int NroSesiones { get; set; }
        //public int IdUsuarioRolAplicacion { get; set; }
    }
}

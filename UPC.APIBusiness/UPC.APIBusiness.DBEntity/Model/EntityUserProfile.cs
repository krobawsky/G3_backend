using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
    public class EntityUserProfile : EntityBase
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string Ruc { get; set; }
        public string RazonSocial { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }

    }
}

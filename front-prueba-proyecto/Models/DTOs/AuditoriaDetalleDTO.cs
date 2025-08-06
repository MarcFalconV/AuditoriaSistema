using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    internal class AuditoriaDetalleDTO
    {
        public int IdAuditoria { get; set; }
        public string Titulo { get; set; }
        public string Ubicacion { get; set; }
        public string Facultad { get; set; }
        public string Departamento { get; set; }
        public string PersonaEncuestada { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
    }
}

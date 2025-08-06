using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class RespuestaDetalleDto
    {
        public int IdRespuesta { get; set; }
        public string Titulo { get; set; }               
        public string Auditoria { get; set; }            
        public string Pregunta { get; set; }             
        public string Respuesta { get; set; }            
        public string Porcentaje { get; set; }           
        public int CantidadDePregunta { get; set; }      
        public int ItemsEvaluados { get; set; }
    }
}

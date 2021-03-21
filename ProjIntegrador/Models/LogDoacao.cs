using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjIntegrador.Models
{
    public class LogDoacao
    {
        [Key]
        public int IdDoacao { get; set; }
        public int IdDoador { get; set; }
        public DateTime DataDoacao { get; set; }
        public Boolean DisponibilidadeBusca { get; set; }
    }
}

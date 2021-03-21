using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjIntegrador.Models
{
    public class Doacoes
    {
        [Key]
        public int IdDoacao { get; set; }
        public int Blusa { get; set; }
        public int Jaqueta { get; set; }
    }
}

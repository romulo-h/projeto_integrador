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
        public int Casaco { get; set; }
        public int BlusaComprida { get; set; }
        public int Calca { get; set; }
        public int Short { get; set; }
        public int Bermuda { get; set; }
        public int Saia { get; set; }
        public int Genero { get; set; }
        public string Tamanho { get; set; }
        public Boolean Disponibilidade { get; set; }
        public string Calcado { get; set; }
        public int Cobertor { get; set; }
        public int IdEndereco { get; set; }
        public int IdDoador { get; set; }
        public DateTime? DataDoacao { get; set; }
        public string Outros { get; set; }

        public Doacoes()
        {

        }
    }
}

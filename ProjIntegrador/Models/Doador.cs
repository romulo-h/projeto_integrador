using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjIntegrador.Models
{
    public class Doador
    {
        [Key]
        public int IdDoador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime? DataCadastro { get; set; }

        public Doador()
        {

        }
        
        public void SalvarDoador()
        {
            
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{

    public class Alunos
    {
        public int Id { get; set; }
        
        [Display(Name= "Mátricula")]
        public int Matricula { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        public string Senha { get; set; }

        [Display(Name = "Celular")]
        public int Celular { get; set; }
    }
}

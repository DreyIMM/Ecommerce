using Ecommerce.Models.Enums;
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
        
        [Required(ErrorMessage ="Digite a matricula")]
        public int Matricula { get; set; }

        [Required(ErrorMessage = "Digite o nome")]
        public string Nome { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }          
        public int Celular { get; set; }
        public PerfilEnum Perfil { get; set; }

        public bool SenhaValid(string senha)
        {
            return Senha == senha;
        }
    }
}

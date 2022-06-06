using Ecommerce.Data;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly BancoContext _context;

        public AlunoRepositorio(BancoContext bancoContext)
        {
            this._context  = bancoContext;
        }

        public Alunos BuscarPorLogin(int matricula )
        {
            return _context.Alunos.FirstOrDefault(x => x.Matricula == matricula);
        }




    }
}

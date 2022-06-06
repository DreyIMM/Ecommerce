using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Repositorio
{
    public interface IAlunoRepositorio
    {
        Alunos BuscarPorLogin(int matricula); 
        

    }
}

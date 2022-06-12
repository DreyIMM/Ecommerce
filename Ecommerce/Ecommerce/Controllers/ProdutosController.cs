using Ecommerce.Models;
using Ecommerce.Repositorio;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class Produtos : Controller
    {

        //private readonly IAlunoRepositorio _alunoRepositorio;

        public Produtos()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}

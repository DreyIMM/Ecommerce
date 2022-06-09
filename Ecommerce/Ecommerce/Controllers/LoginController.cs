using Ecommerce.Models;
using Ecommerce.Repositorio;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class LoginController : Controller
    {

        private readonly IAlunoRepositorio _alunoRepositorio;

        public LoginController(IAlunoRepositorio alunoRepositorio)
        {
            this._alunoRepositorio = alunoRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                // erro aqui
                if (ModelState.IsValid)
                {
                    Alunos alunos = _alunoRepositorio.BuscarPorLogin(loginModel.Matricula);
                    if(alunos != null)
                    {
                        if (alunos.SenhaValid(loginModel.Senha))
                        {
                            return RedirectToAction("Index", "HomeProdutos");
                        }
                        else
                        {
                            TempData["MensagemErro"] = $"Senha incorreta. Tente novamente";
                        }
                    }

                }

                return View("Index");
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não conseguimos localizar seu cadastro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

    }
}

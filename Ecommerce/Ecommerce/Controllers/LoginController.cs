using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logar(string matricula, string senha)
        {

            MySqlConnection mySqlConnection = new MySqlConnection("server=localhost; database=uvajunior;uid=root; password=aa34244942");
            await mySqlConnection.OpenAsync();
            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();

            mySqlCommand.CommandText = $"SELECT * FROM alunos WHERE matricula = '{matricula}' AND password='{senha}' ";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            if(await reader.ReadAsync())
            {
               return Json(new { Msg = "Usuario logado com sucesso !" });
            }

            return Json(new { Msg = "Usuario não encontrado, verifique suas credencias !" });

            

        }
    }
}

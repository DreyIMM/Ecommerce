using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class HomeProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

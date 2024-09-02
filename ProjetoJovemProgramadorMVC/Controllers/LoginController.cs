using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace ProjetoJovemProgramadorMVC.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Logar(string username, string senha)
        //{
            
        //    return Json(new { });
        //}
    }
}

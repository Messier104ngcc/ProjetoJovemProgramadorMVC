using Microsoft.AspNetCore.Mvc;

namespace ProjetoJovemProgramadorMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

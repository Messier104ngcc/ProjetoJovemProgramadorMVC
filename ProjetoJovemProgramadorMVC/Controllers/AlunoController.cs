using Microsoft.AspNetCore.Mvc;
using ProjetoJovemProgramadorMVC.Date.Repositorio.Interfaceer;
using ProjetoJovemProgramadorMVC.Models;

namespace ProjetoJovemProgramadorMVC.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }
        public IActionResult Index()
        {
            var aluno = _alunoRepositorio.BuscarAlunos();
            return View(aluno);
        }

        //criando uma ação para o botão ADICIONAR ALUNO já criado no index
        public IActionResult AdicionarAluno()
        {
            return View();
        }

        public IActionResult InserirAluno(Aluno aluno) // classe Aluno e obejeto que referencia a classe aluno.
        {
            //
            try
            {
                _alunoRepositorio.InserirAlunos(aluno);
            }
            catch (Exception ex)
            {
                //ex.Error(ex, "Ocorreu um erro ao processar a requisição.");
                //ModelState.AddModelError(string.Empty, "Ocorreu um erro inesperado. Por favor, tente novamente mais tarde.");
            }

            return RedirectToAction("Index");
        }


    }
}
using ProjetoJovemProgramadorMVC.Date.Repositorio.Interfaceer;
using ProjetoJovemProgramadorMVC.Models;

namespace ProjetoJovemProgramadorMVC.Date.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Aluno> BuscarAlunos()
        {
            return _bancoContexto.Aluno.ToList();
        }
    }
}

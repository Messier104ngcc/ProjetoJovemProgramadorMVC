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

        // comando para buscar os dados do banco.
        public List<Aluno> BuscarAlunos()
        {
            return _bancoContexto.Aluno.ToList();
        }

        //responsavel por inserir os dados no banco
        public void InserirAlunos(Aluno aluno)
        {
            _bancoContexto.Aluno.Add(aluno); //inseri os dados no banco.
            _bancoContexto.SaveChanges(); //salva os dados no bando.
        }
    }
}

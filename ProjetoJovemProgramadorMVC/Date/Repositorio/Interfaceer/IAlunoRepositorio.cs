using ProjetoJovemProgramadorMVC.Models;

namespace ProjetoJovemProgramadorMVC.Date.Repositorio.Interfaceer
{
    public interface IAlunoRepositorio
    {
        List<Aluno> BuscarAlunos();


        // recebe todos os parametros digidados no formulario aluno.
        void InserirAlunos(Aluno aluno);
    }
}

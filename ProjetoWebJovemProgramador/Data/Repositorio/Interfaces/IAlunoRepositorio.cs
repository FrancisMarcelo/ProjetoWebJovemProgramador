
using ProjetoWebJovemProgramador.Models;

namespace ProjetoWebJovemProgramador.Data.Repositorio.Interfaces
{


    public interface IAlunoRepositorio
    {
        List<Aluno> BuscarAlunos();


        void InserirAluno(Aluno aluno);
        void DeletarAluno(Aluno aluno);

        void AtualizarAluno(Aluno aluno);

        Aluno BuscarAlunoPorId(int id);
    }


}

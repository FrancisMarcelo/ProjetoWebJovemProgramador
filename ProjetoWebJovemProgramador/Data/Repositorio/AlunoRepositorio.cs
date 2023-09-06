using Microsoft.EntityFrameworkCore.Diagnostics;
using ProjetoWebJovemProgramador.Data.Repositorio.Interfaces;
using ProjetoWebJovemProgramador.Models;


namespace ProjetoWebJovemProgramador.Data.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {



        private readonly BancoContexto _bancoContexto;



        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
            
        }

        public void AtualizarAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Update(aluno);
            _bancoContexto.SaveChanges();
            
        }

        public Aluno BuscarAlunoPorId(int id)
        {
           return  _bancoContexto.Aluno.Find(id);

        }

        public List<Aluno> BuscarAlunos()
        {
            return _bancoContexto.Aluno.ToList();
        }

        public void DeletarAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Remove(aluno);
            _bancoContexto.SaveChanges();
        }

        public  void InserirAluno(Aluno aluno)
        {
             _bancoContexto.Aluno.Add(aluno);
            _bancoContexto.SaveChanges();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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



        public List<Aluno> BuscarAlunos()
        {
            return _bancoContexto.Aluno.ToList();
        }



        public void InserirAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Add(aluno);
            _bancoContexto.SaveChanges();
        }
        public void DeletarAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Remove(aluno);
            _bancoContexto.SaveChanges();
        }

        public void AtualizarAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Update(aluno);
            _bancoContexto.SaveChanges();
        }
        public Aluno BuscarAlunoPorId(int id)
        {
            return _bancoContexto.Aluno.Find(id);
        }
       

    }
}

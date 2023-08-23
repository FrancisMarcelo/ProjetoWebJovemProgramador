using Microsoft.AspNetCore.Mvc;
using ProjetoWebJovemProgramador.Data.Repositorio.Interfaces;
using ProjetoWebJovemProgramador.Models;
using System.Text.Json;

namespace ProjetoWebJovemProgramador.Controllers
{
    public class AlunosController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IAlunoRepositorio _alunoRepositorio;



        public AlunosController(IConfiguration configuration, IAlunoRepositorio alunoRepositorio)
        {
            _configuration = configuration;
            _alunoRepositorio = alunoRepositorio;

        }
        public IActionResult AlunoList()
        {
            var aluno = _alunoRepositorio.BuscarAlunos();
            return View(aluno);
        }
        


        public IActionResult InserirAluno(Aluno aluno)
        {
            try
            {
                _alunoRepositorio.InserirAluno(aluno);
            }
            catch (Exception ex)
            {
                TempData["MsgErro"] = "Erro ao inserir aluno!";
            }
            TempData["MsgSucesso"] = "Aluno adicionado com sucesso!";



            return RedirectToAction("AlunoList");
        }

        public IActionResult DeletarAluno(Aluno aluno)
        {
            try
            {
                _alunoRepositorio.DeletarAluno(aluno);
            }
            catch (Exception ex)
            {
                TempData["MsgErro"] = "Erro ao Deletar aluno!";
            }
            TempData["MsgSucesso"] = "Aluno Deletado com sucesso!";



            return RedirectToAction("AlunoList");

        }
       
        public IActionResult AtualizarAluno(int id, string novoNome)
        {
            try
            {
                var aluno = _alunoRepositorio.BuscarAlunoPorId(id);

                if (aluno != null)
                {
                    aluno.Nome = novoNome;
                    _alunoRepositorio.AtualizarAluno(aluno);
                }
                else
                {
                    TempData["MsgErro"] = "Aluno não encontrado!";
                }
            }
            catch (Exception ex)
            {
                TempData["MsgErro"] = "Erro ao atualizar aluno!";
            }

            TempData["MsgSucesso"] = "Aluno atualizado com sucesso!";
            return RedirectToAction("AlunoList");
        }
     



        public async Task<IActionResult> BuscarEndereco(string cep)
        {
            Endereco endereco = new Endereco();



            try
            {
                cep = cep.Replace("-", "");



                using var client = new HttpClient();
                var result = await client.GetAsync(_configuration.GetSection("ApiCep")["BaseUrl"] + cep + "/json");



                if (!result.IsSuccessStatusCode)
                {
                    ViewData["MsgErro"] = "Erro na busca de endereço!";



                }
                else
                {
                    endereco = JsonSerializer.Deserialize<Endereco>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions() { });



                }
            }
            catch (Exception)
            {
                throw;
            }
            return View("Endereco", endereco);
        }
    }
}
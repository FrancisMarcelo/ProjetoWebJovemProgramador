
using Microsoft.AspNetCore.Mvc;
using ProjetoWebJovemProgramador.Data.Repositorio.Interfaces;
using ProjetoWebJovemProgramador.Models;

namespace ProjetoWebJovemProgramador.Controllers
{
    public class LoginController : Controller
    {

        private readonly ILoginRepositorio _loginRepositorio;
        private readonly IConfiguration _configuration;


        public LoginController(ILoginRepositorio loginRepositorio, IConfiguration configuration)
        {
            _loginRepositorio = loginRepositorio;
             _configuration = configuration;
    }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult BuscaLogin(Login login)
        {
            try
            {
                var acesso = _loginRepositorio.ValidarUsuario(login);
                if (acesso != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["MsgErro"] = "Erro, Usuario ou Senha incorretos, tente novamente!";
                    return View("Login", login);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return View("Index");
        }



    }
}

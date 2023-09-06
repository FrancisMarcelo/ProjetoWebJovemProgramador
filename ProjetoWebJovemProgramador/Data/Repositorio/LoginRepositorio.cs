using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoWebJovemProgramador.Data.Repositorio.Interfaces;
using ProjetoWebJovemProgramador.Models;

namespace ProjetoWebJovemProgramador.Data.Repositorio
{
    public class LoginRepositorio : ILoginRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public LoginRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }
        public Login ValidarUsuario(Login login)
        {
          return _bancoContexto.Login.FirstOrDefault(x => x.Usuario == login.Usuario && x.Senha == login.Senha);
           
        }
        


    }
}

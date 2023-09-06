
using ProjetoWebJovemProgramador.Models;

namespace ProjetoWebJovemProgramador.Data.Repositorio.Interfaces
{


    public interface ILoginRepositorio
    {
        Login ValidarUsuario(Login login);
    }


}

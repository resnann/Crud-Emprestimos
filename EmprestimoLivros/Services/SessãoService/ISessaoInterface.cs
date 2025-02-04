using EmprestimoLivros.Models;

namespace EmprestimoLivros.Services.SessãoService
{
    public interface ISessaoInterface
    {
        UsuarioModel BuscarSessao();
        void CriarSessao(UsuarioModel usuarioModel);
        void RemoveSessao();
    }
}

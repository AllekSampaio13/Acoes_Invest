using AcoesInvest.Domain.Interfaces.Repositories;
using AcoesInvest.Domain.Interfaces.Services;
using AcoesInvest.Domain.Models;

namespace AcoesInvest.Domain.Services;

public class UsuariosService : IUsuariosService
{
    private readonly IUsuariosRepository _usuariosRepository;

    public UsuariosService(IUsuariosRepository usuariosRepository)
    {
        _usuariosRepository = usuariosRepository;
    }

    public async Task<IEnumerable<Usuarios>> BuscarUsuarios()
    {
        return await _usuariosRepository.BuscarUsuarios();
    }

    public async Task<IEnumerable<Usuarios>> BuscarUsuariosNome(string nome)
    {
        return await _usuariosRepository.BuscarUsuariosNome(nome);
    }

    public async Task<Usuarios> CadastrarUsuario(Usuarios usuarios)
    {
        var verificaEmail = await _usuariosRepository.Get(x => x.Email == usuarios.Email);
        
        if (verificaEmail != null)
        {
                throw new Exception("Email já cadastrado.");
        }

        await _usuariosRepository.CadastrarUsuarios(usuarios);
        await _usuariosRepository.UnitOfWork.SaveChangesAsync();


        return usuarios;
    }


}

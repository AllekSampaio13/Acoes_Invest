using AcoesInvest.Domain.Models;

namespace AcoesInvest.Domain.Interfaces.Services;

public interface IUsuariosService
{
    Task<IEnumerable<Usuarios>> BuscarUsuarios();
}

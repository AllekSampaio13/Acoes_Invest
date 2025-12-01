using AcoesInvest.Domain.Models;

namespace AcoesInvest.Domain.Interfaces.Repositories;

public interface IUsuariosRepository : IBaseRepository<Usuarios>
{
    Task<IEnumerable<Usuarios>> BuscarUsuarios();
}

using AcoesInvest.Domain.Models;

namespace AcoesInvest.Domain.Interfaces.Repositories;

public interface IAcoesRepository : IBaseRepository<Acoes>
{
    Task<IEnumerable<Acoes>> BuscarAcoes();
}

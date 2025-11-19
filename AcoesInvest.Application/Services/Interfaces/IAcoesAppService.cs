using AcoesInvest.Application.ViewModel;

namespace AcoesInvest.Application.Services.Interfaces;

public interface IAcoesAppService
{
    Task<IEnumerable<AcoesViewModel>> BuscarAcoes();
    Task<IEnumerable<AcoesViewModel>> BuscarAcoesNome(string nome);
    Task<AcoesViewModel> CadastrarAcoes(NovoAcoesViewModel novoAcoesViewModel);
}

using AcoesInvest.Application.Services.Interfaces;
using AcoesInvest.Application.ViewModel;
using AcoesInvest.Domain.Interfaces.Services;
using AutoMapper;

namespace AcoesInvest.Application.Services;

public class UsuariosAppService : IUsuariosAppService
{
    private readonly IUsuariosService _usuariosService;
    private readonly IMapper _Mapper;

    public UsuariosAppService(IUsuariosService usuariosService, IMapper mapper)
    {
        _usuariosService = usuariosService;
        _Mapper = mapper;
    }

    public async Task<IEnumerable<UsuariosViewModel>> BuscarUsuarios()
    {
        return _Mapper.Map<IEnumerable<UsuariosViewModel>>(await _usuariosService.BuscarUsuarios());
    }


}

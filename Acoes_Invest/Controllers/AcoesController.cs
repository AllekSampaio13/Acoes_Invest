using AcoesInvest.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Acoes_Invest.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AcoesController : Controller
{
    private readonly IAcoesAppService _acoesAppService;
    public AcoesController(IAcoesAppService acoesAppService)
    {
        _acoesAppService = acoesAppService;
    }

    [HttpGet("api/acoes/listar")]
    public async Task<IActionResult> BuscarAcoes()
    {
        return Ok(await _acoesAppService.BuscarAcoes());
    }



}


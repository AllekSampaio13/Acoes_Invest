using AcoesInvest.Application.ViewModel;
using AcoesInvest.Domain.Models;
using AutoMapper;

namespace AcoesInvest.Application.Mapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Acoes, AcoesViewModel>();
        }

    }
}

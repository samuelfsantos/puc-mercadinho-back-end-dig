using Puc.Mercadinho.Api.Dto;

namespace Puc.Mercadinho.Api.Application
{
    public interface IProdutoApplication
    {
        List<ProdutoDto> ObterTodosProdutos();
    }
}

using Puc.Mercadinho.Api.Domain;

namespace Puc.Mercadinho.Api.Data.Repositories
{
    public interface IProdutoRepository
    {
        List<Produto> ObterTodosProdutos();
    }
}

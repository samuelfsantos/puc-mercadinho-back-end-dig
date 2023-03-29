using Puc.Mercadinho.Api.Data.DataInMemory;
using Puc.Mercadinho.Api.Domain;

namespace Puc.Mercadinho.Api.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        public List<Produto> ObterTodosProdutos()
        {
            return ProdutoDataInMemory.GerarProdutos();
        }
    }
}

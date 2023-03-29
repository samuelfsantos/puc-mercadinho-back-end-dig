using Puc.Mercadinho.Api.Data.Repositories;
using Puc.Mercadinho.Api.Dto;

namespace Puc.Mercadinho.Api.Application
{
    public class ProdutoApplication : IProdutoApplication
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoApplication(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public List<ProdutoDto> ObterTodosProdutos()
        {
            var produtos = _produtoRepository.ObterTodosProdutos();
            var produtosDto = produtos.Select(x => new ProdutoDto()
            {
                Nome = x.Nome,
                Descricao = x.Descricao,
                Img = x.Img,
                Categoria = x.Categoria,
                Preco = x.Preco,
                Estoque = x.Estoque
            });

            return produtosDto.ToList();
        }
    }
}

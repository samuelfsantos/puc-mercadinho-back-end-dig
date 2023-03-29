namespace Puc.Mercadinho.Api.Domain
{
    public class Produto
    {
        public Produto(
            string nome,
            string descricao,
            string img, 
            string categoria, 
            decimal preco, 
            int estoque)
        {
            Nome = nome;
            Descricao = descricao;
            Img = img;
            Categoria = categoria;
            Preco = preco;
            Estoque = estoque;
        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string Img { get; private set; }
        public string Categoria { get; private set; }
        public decimal Preco { get; private set; }
        public int Estoque { get; private set; }
    }
}

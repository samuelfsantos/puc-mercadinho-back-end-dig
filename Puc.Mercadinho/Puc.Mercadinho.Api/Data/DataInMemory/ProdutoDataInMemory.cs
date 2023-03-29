using Puc.Mercadinho.Api.Domain;

namespace Puc.Mercadinho.Api.Data.DataInMemory
{
    public static class ProdutoDataInMemory
    {
        public static List<Produto> GerarProdutos()
        {
            var produtos = new List<Produto>();

            produtos.Add(new Produto("Cerveja Corona", "Extra Pilsen 330ml Long Neck", ImagemDataInMemory.ImgBebidaAlcoolicaCorona01, "Bebidas alcóolicas", (decimal)6.19, 100));
            produtos.Add(new Produto("Cerveja Stella Artois", "Puro Malte 275ml Long Neck", ImagemDataInMemory.ImgBebidaAlcoolicaStella01, "Bebidas alcóolicas", (decimal)4.99, 100));
            produtos.Add(new Produto("Cerveja Budweiser", "American Lager 330ml Long Neck", ImagemDataInMemory.ImgBebidaAlcoolicaBudweiser01, "Bebidas alcóolicas", (decimal)4.79, 100));
            produtos.Add(new Produto("Cerveja EISENBAHN", "Pilsen Puro Malte Long Neck 355ml", ImagemDataInMemory.ImgBebidaAlcoolicaEisenbahn01, "Bebidas alcóolicas", (decimal)4.79, 100));

            produtos.Add(new Produto("Cerveja HEINEKEN", "Zero Álcool Lata 350ml", ImagemDataInMemory.ImgBebidaHeineken01, "Bebidas", (decimal)4.99, 100));
            produtos.Add(new Produto("Suco de Laranja", "Integral Natural One Ambiente Garrafa 1,5l", ImagemDataInMemory.ImgBebidaSucoLaranja01, "Bebidas", (decimal)12.99, 50));
            produtos.Add(new Produto("Refrigerante PEPSI", "Lata 350ml", ImagemDataInMemory.ImgBebidaPepsi01, "Bebidas", (decimal)1.99, 50));
            produtos.Add(new Produto("Água Mineral", "Sem Gás Crystal GARRAFÃO 5L", ImagemDataInMemory.ImgBebidaAgua01, "Bebidas", (decimal)8.59, 50));

            produtos.Add(new Produto("Carne de boi Picanha", "Resfriada Maturatta Friboi 1,3kg", ImagemDataInMemory.ImgCarneAvePicanha01, "Carnes e Aves", (decimal)168.34, 10));
            produtos.Add(new Produto("Carne de boi Contra Filé", "Maturatta Friboi Resfriado Pedaço 1,2kg", ImagemDataInMemory.ImgCarneAveContraFile01, "Carnes e Aves", (decimal)98.37, 15));
            produtos.Add(new Produto("Filé De Peito De Frango", "SEARA Assa Fácil Com Ervas Finas Pacote 800g", ImagemDataInMemory.ImgCarneAveFilePeito01, "Carnes e Aves", (decimal)27.99, 25));
            produtos.Add(new Produto("Coxa e Sobrecoxa de Frango", "Desossados SADIA Congelado 1kg", ImagemDataInMemory.ImgCarneAveCoxaSobrecoxa01, "Carnes e Aves", (decimal)25.99, 25));

            produtos.Add(new Produto("Biscoito BONO", "Recheado Chocolate 126g", ImagemDataInMemory.ImgBiscoitoBono01, "Biscoitos e Bolachas", (decimal)2.49, 150));
            produtos.Add(new Produto("Biscoito recheado Oreo", "original multipack 144g", ImagemDataInMemory.ImgBiscoitoOreo01, "Biscoitos e Bolachas", (decimal)5.59, 150));
            produtos.Add(new Produto("Biscoito BAUDUCCO", "Wafer de Chocolate Pacote 140g", ImagemDataInMemory.ImgBiscoitoBauducco01, "Biscoitos e Bolachas", (decimal)3.75, 150));
            produtos.Add(new Produto("NESFIT Biscoito", "Limão e Cereais 160g", ImagemDataInMemory.ImgBiscoitoNesfit01, "Biscoitos e Bolachas", (decimal)3.99, 150));

            produtos.Add(new Produto("Feijão Carioca", "Tipo 1 CAMIL Pacote 1kg", ImagemDataInMemory.ImgGraoFeijao01, "Grãos e Cereais", (decimal)8.99, 80));
            produtos.Add(new Produto("Arroz Agulhinha", "Tipo 1 CAMIL Pacote 5kg", ImagemDataInMemory.ImgGraoArroz01, "Grãos e Cereais", (decimal)22.79, 80));
            produtos.Add(new Produto("Milho para Pipoca", "YOKI 500g", ImagemDataInMemory.ImgGraoMilho01, "Grãos e Cereais", (decimal)6.02, 80));
            produtos.Add(new Produto("Aveia Em Flocos Regulares", "Quaker Caixa 450G Embalagem Econômica", ImagemDataInMemory.ImgGraoAveia01, "Grãos e Cereais", (decimal)10.79, 80));

            return produtos;
        }
    }
}

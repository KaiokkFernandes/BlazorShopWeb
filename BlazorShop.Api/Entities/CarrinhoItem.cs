namespace BlazorShop.Api.Entities
{
    public class CarrinhoItem
    {
        public int Id { get; set; } 

        public int CarinhoId { get; set; }
        public int ProdutoId { get; set; }  
        public int Quantidade { get; set; } 

        public Carrinho? Carrinho { get; set; }
        public Produto? Produto { get; set; }   

    }
}

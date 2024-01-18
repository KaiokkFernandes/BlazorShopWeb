using System.Collections.ObjectModel;

namespace BlazorShop.Api.Entities
{
    public class Categoria
    {
        public int Id { get; set; } // como irei usar Entity framework e bom ter uma id para chave primaria  

        public string Nome { get; set; } = string.Empty;
        public string IconCSS { get; set; } = string.Empty;


        public Collection<Produto> Produtos { get; set; }
         = new Collection<Produto>();
    }
}
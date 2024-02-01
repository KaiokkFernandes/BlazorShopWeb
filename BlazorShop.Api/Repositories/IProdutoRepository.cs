using BlazorShop.Api.Entities;
using System.Data.SqlTypes;

namespace BlazorShop.Api.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetItens();
        Task<Produto> GetItens(int id);

        Task<IEnumerable<Produto>> GetItensPorCategorias(int id); 
        Task<IEnumerable<Categoria>> GetCategorias();   
    }
}

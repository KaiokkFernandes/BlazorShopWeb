using BlazorShop.Api.Context;
using BlazorShop.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BlazorShop.Api.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Categoria>> GetCategorias()
        {
            throw new NotImplementedException();
        }

        public async  Task<Produto> GetItens(int id)
        {
            var produto = await _context.Produtos
                     .Include(c => c.Categoria)
                     .SingleOrDefaultAsync(c => c.Id == id);

            return produto;
        }

        public async Task<IEnumerable<Produto>> GetItens()
        {
            var produtos = await _context.Produtos
                          .Include(p => p.Categoria)
                          .ToListAsync();

            return produtos;
        }

        public async Task<IEnumerable<Produto>> GetItensPorCategorias(int id)
        {
            var produtos = await _context.Produtos
                 .Include(p => p.Categoria)
                 .Where(p => p.CategoriaId == id).ToListAsync();

            return produtos;
        }
    }
}

using SistemaGestaoPortfolioInvestimentos.Data;
using SistemaGestaoPortfolioInvestimentos.Interfaces;
using SistemaGestaoPortfolioInvestimentos.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaGestaoPortfolioInvestimentos.DAO
{
    public class ProductDAO:IProductDAO
    {
        private readonly DataBaseContext _context;

        public ProductDAO(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync() => await _context.Products.ToListAsync();
        public async Task<Product> GetProductByIdAsync(int id) => await _context.Products.FindAsync(id);
        public async Task AddProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
    }
}

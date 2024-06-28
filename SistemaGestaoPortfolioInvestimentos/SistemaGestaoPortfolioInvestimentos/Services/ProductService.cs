using SistemaGestaoPortfolioInvestimentos.Interfaces;
using SistemaGestaoPortfolioInvestimentos.Models;

namespace SistemaGestaoPortfolioInvestimentos.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductDAO _productDAO;

        public ProductService(IProductDAO productRepository)
        {
            _productDAO = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync() => await _productDAO.GetAllProductsAsync();
        public async Task<Product> GetProductByIdAsync(int id) => await _productDAO.GetProductByIdAsync(id);
        public async Task AddProductAsync(Product product) => await _productDAO.AddProductAsync(product);
        public async Task UpdateProductAsync(Product product) => await _productDAO.UpdateProductAsync(product);
        public async Task DeleteProductAsync(int id) => await _productDAO.DeleteProductAsync(id);
    }
}

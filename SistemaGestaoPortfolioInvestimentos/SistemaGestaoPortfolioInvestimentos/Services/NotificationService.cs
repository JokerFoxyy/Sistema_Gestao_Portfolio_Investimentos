using SistemaGestaoPortfolioInvestimentos.Interfaces;

namespace SistemaGestaoPortfolioInvestimentos.Services
{
    public class NotificationService
    {
        private readonly IProductService _productService;
        private readonly EmailService _emailService;

        public NotificationService(IProductService productService, EmailService emailService)
        {
            _productService = productService;
            _emailService = emailService;
        }

        public async Task SendDailyNotificationsAsync()
        {
            var products = await _productService.GetAllProductsAsync();
            var productsNearMaturity = products.Where(p => p.MaturityDate <= DateTime.Now.AddDays(7));

            foreach (var product in productsNearMaturity)
            {
                var subject = $"Product {product.Name} is near maturity";
                var body = $"The product {product.Name} will mature on {product.MaturityDate.ToShortDateString()}";
                await _emailService.SendEmailAsync("admin@example.com", subject, body);
            }
        }
    }
}

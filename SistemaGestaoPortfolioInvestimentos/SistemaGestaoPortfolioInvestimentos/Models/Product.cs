namespace SistemaGestaoPortfolioInvestimentos.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime MaturityDate { get; set; }
        public decimal Price { get; set; }
    }
}

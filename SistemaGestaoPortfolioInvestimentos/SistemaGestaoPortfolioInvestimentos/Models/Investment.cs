namespace SistemaGestaoPortfolioInvestimentos.Models
{
    public class Investment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Amount { get; set; }
    }
}

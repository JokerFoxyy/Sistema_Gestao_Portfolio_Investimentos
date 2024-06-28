using SistemaGestaoPortfolioInvestimentos.Models;

namespace SistemaGestaoPortfolioInvestimentos.Interfaces
{
    public interface IInvestmentService
    {
        Task<IEnumerable<Investment>> GetAllInvestmentsAsync(int clientId);
        Task<Investment> GetInvestmentByIdAsync(int clientId, int investmentId);
        Task BuyInvestmentAsync(int clientId, Investment investment);
        Task SellInvestmentAsync(int clientId, int investmentId);
    }
}

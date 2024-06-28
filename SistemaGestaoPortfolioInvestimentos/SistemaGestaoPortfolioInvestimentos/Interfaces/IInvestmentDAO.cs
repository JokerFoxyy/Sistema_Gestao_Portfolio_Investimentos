using SistemaGestaoPortfolioInvestimentos.Models;

namespace SistemaGestaoPortfolioInvestimentos.Interfaces
{
    public interface IInvestmentDAO
    {
        Task<IEnumerable<Investment>> GetAllInvestmentsAsync(int clientId);
        Task<Investment> GetInvestmentByIdAsync(int clientId, int investmentId);
        Task AddInvestmentAsync(Investment investment);
        Task DeleteInvestmentAsync(int clientId, int investmentId);
    }
}

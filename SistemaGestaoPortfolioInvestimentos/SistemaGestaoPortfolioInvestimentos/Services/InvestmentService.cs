using SistemaGestaoPortfolioInvestimentos.DAO;
using SistemaGestaoPortfolioInvestimentos.Interfaces;
using SistemaGestaoPortfolioInvestimentos.Models;

namespace SistemaGestaoPortfolioInvestimentos.Services
{
    public class InvestmentService: IInvestmentService
    {
        private readonly IInvestmentDAO _investmentDAO;

        public InvestmentService(IInvestmentDAO investmentRepository)
        {
            _investmentDAO = investmentRepository;
        }

        public async Task<IEnumerable<Investment>> GetAllInvestmentsAsync(int clientId)
        {
            return await _investmentDAO.GetAllInvestmentsAsync(clientId);
        }

        public async Task<Investment> GetInvestmentByIdAsync(int clientId, int investmentId)
        {
            return await _investmentDAO.GetInvestmentByIdAsync(clientId, investmentId);
        }

        public async Task BuyInvestmentAsync(int clientId, Investment investment)
        {
            investment.ClientId = clientId;
            investment.PurchaseDate = DateTime.Now;
            await _investmentDAO.AddInvestmentAsync(investment);
        }

        public async Task SellInvestmentAsync(int clientId, int investmentId)
        {
            await _investmentDAO.DeleteInvestmentAsync(clientId, investmentId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SistemaGestaoPortfolioInvestimentos.Data;
using SistemaGestaoPortfolioInvestimentos.Interfaces;
using SistemaGestaoPortfolioInvestimentos.Models;

namespace SistemaGestaoPortfolioInvestimentos.DAO
{
    public class InvestmentDAO:IInvestmentDAO
    {
        private readonly DataBaseContext _context;

        public InvestmentDAO(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Investment>> GetAllInvestmentsAsync(int clientId)
        {
            return await _context.Investments
                .Where(i => i.ClientId == clientId)
                .ToListAsync();
        }

        public async Task<Investment> GetInvestmentByIdAsync(int clientId, int investmentId)
        {
            return await _context.Investments
                .FirstOrDefaultAsync(i => i.ClientId == clientId && i.Id == investmentId);
        }

        public async Task AddInvestmentAsync(Investment investment)
        {
            await _context.Investments.AddAsync(investment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInvestmentAsync(int clientId, int investmentId)
        {
            var investment = await _context.Investments
                .FirstOrDefaultAsync(i => i.ClientId == clientId && i.Id == investmentId);
            if (investment != null)
            {
                _context.Investments.Remove(investment);
                await _context.SaveChangesAsync();
            }
        }
    }
}

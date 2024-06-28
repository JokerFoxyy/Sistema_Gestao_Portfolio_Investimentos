using Microsoft.AspNetCore.Mvc;
using SistemaGestaoPortfolioInvestimentos.Interfaces;
using SistemaGestaoPortfolioInvestimentos.Models;

namespace SistemaGestaoPortfolioInvestimentos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvestmentsController : Controller
    {
        private readonly IInvestmentService _investmentService;

        public InvestmentsController(IInvestmentService investmentService)
        {
            _investmentService = investmentService;
        }

        [HttpGet("{clientId}")]
        public async Task<IActionResult> GetAllInvestments(int clientId)
        {
            var investments = await _investmentService.GetAllInvestmentsAsync(clientId);
            return Ok(investments);
        }

        [HttpGet("{clientId}/{investmentId}")]
        public async Task<IActionResult> GetInvestmentById(int clientId, int investmentId)
        {
            var investment = await _investmentService.GetInvestmentByIdAsync(clientId, investmentId);
            if (investment == null) return NotFound();
            return Ok(investment);
        }

        [HttpPost("{clientId}")]
        public async Task<IActionResult> BuyInvestment(int clientId, Investment investment)
        {
            await _investmentService.BuyInvestmentAsync(clientId, investment);
            return CreatedAtAction(nameof(GetInvestmentById), new { clientId = clientId, investmentId = investment.Id }, investment);
        }

        [HttpDelete("{clientId}/{investmentId}")]
        public async Task<IActionResult> SellInvestment(int clientId, int investmentId)
        {
            await _investmentService.SellInvestmentAsync(clientId, investmentId);
            return NoContent();
        }
    }
}

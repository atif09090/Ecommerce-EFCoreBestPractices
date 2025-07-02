using Ecommerce_EFCoreBestPractices.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_EFCoreBestPractices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("active-users-with-orders")]
        public async Task<IActionResult> GetActiveUsersWithOrders()
        {
            var users = await _context.Users
                .Where(u => u.IsActive)
                .Include(u => u.Orders)
                .ThenInclude(o => o.Items)
                .ThenInclude(i => i.Product)
                .AsNoTracking()
                .ToListAsync();

            return Ok(users);
        }

        [HttpGet("paginated-orders")]
        public async Task<IActionResult> GetPaginatedOrders(int page = 0, int pageSize = 10)
        {
            var orders = await _context.Orders
                .Include(o => o.User)
                .OrderByDescending(o => o.CreatedAt)
                .Skip(page * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();

            return Ok(orders);
        }

        [HttpGet("product-search")]
        public async Task<IActionResult> SearchProducts(string keyword)
        {
            var products = await _context.Products
                .Where(p => p.Name.Contains(keyword))
                .OrderBy(p => p.Name)
                .AsNoTracking()
                .ToListAsync();

            return Ok(products);
        }

        [HttpGet("report-total-orders")]
        public async Task<IActionResult> GetOrderStats()
        {
            var totalOrders = await _context.Orders
                .AsNoTracking()
                .CountAsync();

            return Ok(new { totalOrders });
        }
    }

}

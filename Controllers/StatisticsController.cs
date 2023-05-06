using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementOrder.Models.Statistics;
using Stripe;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Controllers
{
    public class StatisticsController : Controller
    {
        protected Data.RestaurantManagementOrderContext _context;
        public StatisticsController(Data.RestaurantManagementOrderContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(new StatisticsModel
            {
                BiggestOrderByQuantity = await _context.Order
                    .Include(o => o.OrderItems)
                    .ThenInclude(o => o.MenuItem)
                    .OrderByDescending(o => o.OrderItems.Sum(oi => oi.Quantity))
                    .FirstOrDefaultAsync(),
                BiggestOrderByPrice = _context.Order
                    .Include(o => o.OrderItems)
                    .ThenInclude(o => o.MenuItem)
                    .ToList()
                    .OrderByDescending(o => o.Total)
                    .FirstOrDefault(),
                MostExpensiveTable = _context.Order
                    .Include(o => o.OrderItems)
                    .ThenInclude(o => o.MenuItem)
                    .GroupBy(o => o.TableNumber)
                    .ToList()
                    .Select(gr => new
                    {
                        tableNum = gr.Key,
                        totalPrice = gr.Sum(o => o.Total)
                    })
                    .OrderByDescending(gr => gr.totalPrice)
                    .Select(gr => new MostExpensiveTableInfo
                    {
                        TableNum = gr.tableNum, TotalPrice = gr.totalPrice,
                    })
                    .FirstOrDefault(),
            });
        }
    }
}

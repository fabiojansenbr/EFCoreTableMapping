using EFCoreTableMapping.Data.Context;
using EFCoreTableMapping.Data.Seed;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTableMapping.Controllers
{
    public class CustomersController : Controller
    {

        public readonly CustomersDbContext _context;

        public CustomersController(CustomersDbContext context)
        {
            _context = context;

            if (!_context.Customers.Any())
            {
                _context.Customers.AddRange(SeedDataBase.CustomersList());
                _context.SaveChanges();
            }
        }

        public async Task<IActionResult> Index()
        {
            var customersList = await _context.Customers
                        .OrderBy(c => c.Name).ToListAsync();

            return View(customersList);
        }
    }
}

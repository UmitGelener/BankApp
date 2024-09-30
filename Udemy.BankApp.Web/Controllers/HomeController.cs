using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Udemy.BankApp.Web.Data.Context;

namespace Udemy.BankApp.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly BankContext _context;

		public HomeController(BankContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}

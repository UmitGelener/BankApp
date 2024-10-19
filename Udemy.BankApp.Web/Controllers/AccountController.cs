using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Udemy.BankApp.Web.Data.Context;
using Udemy.BankApp.Web.Models;

namespace Udemy.BankApp.Web.Controllers
{
	public class AccountController : Controller
	{
		private readonly BankContext _context;

		public AccountController(BankContext context)
		{
			_context = context;
		}
		public IActionResult Create(int id)
		{
			var userInfo = _context.ApplicationUsers.Select(x=>new UserListModel
			{
				ID=x.ID,
				Name = x.Name,
				Surname = x.Surname
			}).SingleOrDefault(x => x.ID == id);
			return View(userInfo);
		}

		[HttpPost]
		public IActionResult Create(AccountCreateModel model)
		{
			_context.Accounts.Add(new Data.Entities.Account
			{
				ApplicationUserID = model.ApplicationUserID,
                AccountNumber = model.AccountNumber,
				Balance = model.Balance
			});
			_context.SaveChanges();


            return RedirectToAction("Index", "Home");
		}
	}
}

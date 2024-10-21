using Microsoft.AspNetCore.Mvc;
using Udemy.BankApp.Web.Data.Context;
using Udemy.BankApp.Web.Data.Interfaces;
using Udemy.BankApp.Web.Data.Mapping;
using Udemy.BankApp.Web.Models;

namespace Udemy.BankApp.Web.Controllers
{
	public class AccountController : Controller
	{
		private readonly BankContext _context;
		private readonly IApplicationUserRepository _applicationUserRepository;
		private readonly IUserMapper _mapper;
		public AccountController(BankContext context, IApplicationUserRepository applicationUserRepository, IUserMapper mapper)
		{
			_context = context;
			_applicationUserRepository = applicationUserRepository;
			_mapper = mapper;
		}
		public IActionResult Create(int id)
		{
			var userInfo = _mapper.MapToUserList(_applicationUserRepository.GetById(id));
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

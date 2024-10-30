using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Linq;
using Udemy.BankApp.Web.Data.Context;
using Udemy.BankApp.Web.Data.Entities;
using Udemy.BankApp.Web.Data.Interfaces;
using Udemy.BankApp.Web.Data.Mapping;
using Udemy.BankApp.Web.Models;

namespace Udemy.BankApp.Web.Controllers
{
	public class AccountController : Controller
	{
		//private readonly BankContext _context;
		//private readonly IApplicationUserRepository _applicationUserRepository;
		//private readonly IUserMapper _mapper;
		//private readonly IAccountRepository _accountRepository;
		//private readonly IAccountMapper _accountMapper;
		//public AccountController(BankContext context, IApplicationUserRepository applicationUserRepository, IUserMapper mapper, IAccountRepository accountRepository, IAccountMapper accountMapper)
		//{
		//	_context = context;
		//	_applicationUserRepository = applicationUserRepository;
		//	_mapper = mapper;
		//	_accountRepository = accountRepository;
		//	_accountMapper = accountMapper;
		//}

		private readonly IRepository<Account> _accountRepository;
		private readonly IRepository<ApplicationUser> _userRepository;

		public AccountController(IRepository<Account> accountRepository, IRepository<ApplicationUser> userRepository)
		{
			_accountRepository = accountRepository;
			_userRepository = userRepository;
		}

		public IActionResult Create(int id)
		{
			var userInfo = _userRepository.GetById(id);
			return View(new UserListModel
			{
				ID = userInfo.ID,
				Name = userInfo.Name,
				Surname = userInfo.Surname
			});
		}

		[HttpPost]
		public IActionResult Create(AccountCreateModel model)
		{
			_accountRepository.Create(new Account
			{
				Balance=model.Balance,
				ApplicationUserID = model.ApplicationUserID,
				AccountNumber = model.AccountNumber
			});

			return RedirectToAction("Index", "Home");
		}

		[HttpGet]
		public IActionResult GetByUserId(int userId)
		{
			var query = _accountRepository.GetQueryable();
			var accountList = query.Where(x => x.ApplicationUserID == userId).ToList();
			var user = _userRepository.GetById(userId);
			ViewBag.FullName = user.Name + " " + user.Surname;
			var list = new List<AccountListModel>();
			foreach (var account in accountList)
			{
				list.Add(new()
				{
					AccountNumber = account.AccountNumber,
					ApplicationUserID = account.ApplicationUserID,
					Balance = account.Balance,
					Id = account.ID
				});
			}

			return View(list);
		}
		[HttpGet]
		public IActionResult SendMoney(int accountId)
		{
			var accounts = _accountRepository.GetQueryable().Where(x => x.ID != accountId).ToList();

			var list = new List<AccountListModel>();

			ViewBag.SenderId = accountId;

			foreach (var account in accounts)
			{
				list.Add(new()
				{
					AccountNumber = account.AccountNumber,
					ApplicationUserID = account.ApplicationUserID,
					Balance = account.Balance,
					Id = account.ID
				});
			}

			return View(new SelectList(list,"Id","AccountNumber"));
		}

		[HttpPost]
		public IActionResult SendMoney(SendMoneyModel model)
		{
			var senderAccount = _accountRepository.GetById(model.SenderId);
			senderAccount.Balance -= model.Amount;
			_accountRepository.Update(senderAccount);

			var account = _accountRepository.GetById(model.AccountId);
			account.Balance += model.Amount;
			_accountRepository.Update(account);

			return RedirectToAction("Index", "Home");
		}
	}
}

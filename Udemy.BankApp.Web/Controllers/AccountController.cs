using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Linq;
using Udemy.BankApp.Web.Data.Context;
using Udemy.BankApp.Web.Data.Entities;
using Udemy.BankApp.Web.Data.Interfaces;
using Udemy.BankApp.Web.Data.Mapping;
using Udemy.BankApp.Web.Data.UnitOfWork;
using Udemy.BankApp.Web.Models;

namespace Udemy.BankApp.Web.Controllers
{
	public class AccountController : Controller
	{
		//private readonly BankContext _context;
		//private readonly IApplicationUserRepository _applicationUserRepository;
		//private readonly IUserMapper _mapper;
		//private readonly IAccountRepository _uow.GetRepository<Account>().;
		//private readonly IAccountMapper _accountMapper;
		//public AccountController(BankContext context, IApplicationUserRepository applicationUserRepository, IUserMapper mapper, IAccountRepository accountRepository, IAccountMapper accountMapper)
		//{
		//	_context = context;
		//	_applicationUserRepository = applicationUserRepository;
		//	_mapper = mapper;
		//	_uow.GetRepository<Account>(). = accountRepository;
		//	_accountMapper = accountMapper;
		//}

		//private readonly IRepository<Account> _uow.GetRepository<Account>().;
		//private readonly IRepository<ApplicationUser> _userRepository;

		//public AccountController(IRepository<Account> accountRepository, IRepository<ApplicationUser> userRepository)
		//{
		//	_uow.GetRepository<Account>(). = accountRepository;
		//	_userRepository = userRepository;
		//}

		private readonly IUow _uow;

		public AccountController(IUow uow)
		{
			_uow = uow;
		}

		public IActionResult Create(int id)
		{
			var userInfo = _uow.GetRepository<ApplicationUser>().GetById(id);
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
			_uow.GetRepository<Account>().Create(new Account
			{
				Balance=model.Balance,
				ApplicationUserID = model.ApplicationUserID,
				AccountNumber = model.AccountNumber
			});
			_uow.SaveChanges();
			return RedirectToAction("Index", "Home");
		}

		[HttpGet]
		public IActionResult GetByUserId(int userId)
		{
			var query = _uow.GetRepository<Account>().GetQueryable();
			var accountList = query.Where(x => x.ApplicationUserID == userId).ToList();
			var user = _uow.GetRepository<ApplicationUser>().GetById(userId);
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
			var accounts = _uow.GetRepository<Account>().GetQueryable().Where(x => x.ID != accountId).ToList();

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
			var senderAccount = _uow.GetRepository<Account>().GetById(model.SenderId);
			senderAccount.Balance -= model.Amount;
			_uow.GetRepository<Account>().Update(senderAccount);

			var account = _uow.GetRepository<Account>().GetById(model.AccountId);
			account.Balance += model.Amount;
			_uow.GetRepository<Account>().Update (account);
			_uow.SaveChanges();
			return RedirectToAction("Index", "Home");
		}
	}
}

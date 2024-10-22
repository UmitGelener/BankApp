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
		private readonly IAccountRepository _accountRepository;
		private readonly IAccountMapper _accountMapper;
		public AccountController(BankContext context, IApplicationUserRepository applicationUserRepository, IUserMapper mapper, IAccountRepository accountRepository, IAccountMapper accountMapper)
		{
			_context = context;
			_applicationUserRepository = applicationUserRepository;
			_mapper = mapper;
			_accountRepository = accountRepository;
			_accountMapper = accountMapper;
		}
		public IActionResult Create(int id)
		{
			var userInfo = _mapper.MapToUserList(_applicationUserRepository.GetById(id));
			return View(userInfo);
		}

		[HttpPost]
		public IActionResult Create(AccountCreateModel model)
		{
			_accountRepository.Create(_accountMapper.Map(model));

			return RedirectToAction("Index", "Home");
		}
	}
}

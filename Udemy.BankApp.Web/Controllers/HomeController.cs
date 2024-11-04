using Microsoft.AspNetCore.Mvc;
using Udemy.BankApp.Web.Data.Context;
using Udemy.BankApp.Web.Data.Entities;
using Udemy.BankApp.Web.Data.Interfaces;
using Udemy.BankApp.Web.Data.Mapping;
using Udemy.BankApp.Web.Data.Repositories;
using Udemy.BankApp.Web.Data.UnitOfWork;

namespace Udemy.BankApp.Web.Controllers
{
	public class HomeController : Controller
	{

		private readonly IUserMapper _mapper;
		private readonly IUow _uow;
		public HomeController(IUserMapper mapper, IUow uow)
		{
			_mapper = mapper;
			_uow = uow;
		}

		public IActionResult Index()
		{
			return View(_mapper.MapToListOfUserList(_uow.GetRepository<ApplicationUser>().GelAll()));
		}
	}
}

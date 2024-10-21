using Microsoft.AspNetCore.Mvc;
using Udemy.BankApp.Web.Data.Context;
using Udemy.BankApp.Web.Data.Interfaces;
using Udemy.BankApp.Web.Data.Mapping;
using Udemy.BankApp.Web.Data.Repositories;

namespace Udemy.BankApp.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly BankContext _context;
		private readonly IApplicationUserRepository _applicationUserRepository;
		private readonly IUserMapper _mapper;
		public HomeController(BankContext context, IApplicationUserRepository applicationUserRepository, IUserMapper mapper)
		{
			_context = context;
			_applicationUserRepository = applicationUserRepository;
			_mapper = mapper;
		}

		public IActionResult Index()
		{
			return View(_mapper.MapToListOfUserList(_applicationUserRepository.GetAll()));
		}
	}
}

﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Udemy.BankApp.Web.Data.Context;
using Udemy.BankApp.Web.Models;

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
			return View(_context.ApplicationUsers.Select(x=>new UserListModel
			{
				ID = x.ID,
				Name = x.Name,
				Surname = x.Surname
			}).ToList());
		}
	}
}

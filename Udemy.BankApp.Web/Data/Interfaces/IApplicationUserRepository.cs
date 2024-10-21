using System.Collections.Generic;
using Udemy.BankApp.Web.Data.Entities;

namespace Udemy.BankApp.Web.Data.Interfaces
{
	public interface IApplicationUserRepository
	{
		public List<ApplicationUser> GetAll();

		public ApplicationUser GetById(int id);
	}
}

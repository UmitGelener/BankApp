using Udemy.BankApp.Web.Data.Entities;
using Udemy.BankApp.Web.Models;

namespace Udemy.BankApp.Web.Data.Mapping
{
	public interface IAccountMapper
	{
		public Account Map(AccountCreateModel account);
	}
}

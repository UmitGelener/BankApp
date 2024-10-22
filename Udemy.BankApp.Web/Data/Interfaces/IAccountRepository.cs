using Udemy.BankApp.Web.Data.Entities;

namespace Udemy.BankApp.Web.Data.Interfaces
{
	public interface IAccountRepository
	{
		public void Create(Account account);
	}
}

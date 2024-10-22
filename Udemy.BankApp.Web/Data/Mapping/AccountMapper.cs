using Udemy.BankApp.Web.Data.Entities;
using Udemy.BankApp.Web.Models;

namespace Udemy.BankApp.Web.Data.Mapping
{
	public class AccountMapper : IAccountMapper
	{
		public Account Map(AccountCreateModel account)
		{
			return new Account
			{
				AccountNumber = account.AccountNumber,
				ApplicationUserID = account.ApplicationUserID,
				Balance = account.Balance
			};
		}
	}
}

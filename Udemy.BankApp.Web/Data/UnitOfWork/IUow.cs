using Udemy.BankApp.Web.Data.Interfaces;

namespace Udemy.BankApp.Web.Data.UnitOfWork
{
	public interface IUow
	{
		public IRepository<T> GetRepository<T>() where T : class, new();
		public void SaveChanges();
	}
}
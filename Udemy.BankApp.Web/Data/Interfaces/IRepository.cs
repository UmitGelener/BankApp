using System.Collections.Generic;
using System.Linq;

namespace Udemy.BankApp.Web.Data.Interfaces
{
	public interface IRepository<T> where T : class,new()
	{
		public void Create(T entity);
		public void Remove(T entity);
		public List<T> GelAll();
		public T GetById(object id);
		public void Update(T entity);
		IQueryable<T> GetQueryable();
	}
}

using System.Collections.Generic;
using System.Linq;
using Udemy.BankApp.Web.Data.Entities;
using Udemy.BankApp.Web.Models;

namespace Udemy.BankApp.Web.Data.Mapping
{
	public class UserMapper : IUserMapper
	{
		public List<UserListModel> MapToListOfUserList(List<ApplicationUser> users)
		{
			return users.Select(x => new UserListModel
			{
				ID = x.ID,
				Name = x.Name,
				Surname = x.Surname
			}).ToList();
		}

		public UserListModel MapToUserList(ApplicationUser user)
		{
			return new UserListModel
			{
				ID = user.ID,
				Name = user.Name,
				Surname = user.Surname
			};
		}
	}
}

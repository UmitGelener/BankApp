namespace Udemy.BankApp.Web.Models
{
	public class UserListModel
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
	}

	public class AccountListModel
	{
        public int Id { get; set; }
        public decimal Balance { get; set; }
		public int AccountNumber { get; set; }
		public int ApplicationUserID { get; set; }
    }
}
	
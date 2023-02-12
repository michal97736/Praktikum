namespace Praktikum.WenAPI.Models
{
	

	public class UserPostModel
	{
		public int UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int TZ { get; set; }
		public DateTime BirthDate { get; set; }
		public string Gender { get; set; }
		public string HMO { get; set; }
	}
}

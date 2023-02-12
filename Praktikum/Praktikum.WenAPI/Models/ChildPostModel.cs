using System.ComponentModel.DataAnnotations.Schema;

namespace Praktikum.WenAPI.Models
{
	public class ChildPostModel
	{
		public int ChildId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int TZ { get; set; }
		public DateTime BirthDate { get; set; }

		[ForeignKey("Parent")]
		public int ParentId { get; set; }
		public UserPostModel Parent { get; set; }
	}
}

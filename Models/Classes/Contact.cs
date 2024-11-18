using System.ComponentModel.DataAnnotations;

namespace Turn8.Models.Classes
{
	public class Contact
	{
		[Key]
		public int Id { get; set; }
		public required string Name { get; set; }
		public required string Mail { get; set; }
		public required string Phone { get; set; }
		public required string Message { get; set; }
	}
}

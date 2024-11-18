using System.ComponentModel.DataAnnotations;

namespace Turn8.Models.Classes
{
	public class About
	{
		[Key]
		public int Id { get; set; }
		public string? ImageUrl { get; set; }
		public required string Description { get; set; }

	}
}
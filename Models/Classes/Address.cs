using System.ComponentModel.DataAnnotations;

namespace Turn8.Models.Classes
{
	public class Address
	{
		[Key]
        public int Id { get; set; }
		public required string Title { get; set; }
		public required string Description { get; set; }
		public required string AddressOne {  get; set; }
		public required string Mail { get; set; }
		public required string Phone { get; set; }

    }
}

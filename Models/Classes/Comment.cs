using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Turn8.Models.Classes
{
	public class Comment
	{
		[Key]
		public int Id { get; set; }
		public required string Name { get; set; }
		public required string Mail { get; set; }
        [DisplayName("Comment")]
        public required string _Comment { get; set; }
		public int BlogId { get; set; }
        public required virtual Blog Blog { get; set; }
	}
}

using System.ComponentModel.DataAnnotations;

namespace Turn8.Models.Classes
{
	public class Admin
	{
        [Key]
        public int Id { get; set; }
        public required string User {  get; set; }
        public required string Password { get; set; }

    }
}

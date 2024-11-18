using System.ComponentModel.DataAnnotations;

namespace Turn8.Models.Classes
{
	public class Blog
	{
        [Key]
        public int Id { get; set; }
        public required string Title { get; set; }
        public required DateOnly Date {  get; set; }
        public required string Description { get; set; }
        public required string BlogImage { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public required int FirstGrandPrix { get; set; }
        public required int NumberOfLaps { get; set; }
        public required float CircuitLength { get; set; }
        public required float RaceDistance { get; set; }
        public required string LapRecord { get; set; }
    }
}

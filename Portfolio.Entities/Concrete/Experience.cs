using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entities.Concrete
{
    public class Experience
    {
        [Key]
        public int ExperienceID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entities.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Github { get; set; }
        public string LinkedIn { get; set; }
    }
}

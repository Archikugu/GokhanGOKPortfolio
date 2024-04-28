using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entities.Concrete
{
    public class Portfolio
    {
        [Key]
        public int PortfolioID { get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }
        public string ProjectUrlTitle { get; set; }
        public string ProjectUrl { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public string ImageUrl4 { get; set; }
        public string Price { get; set; }
        public string Value { get; set; }
        public bool Status { get; set; }
    }
}

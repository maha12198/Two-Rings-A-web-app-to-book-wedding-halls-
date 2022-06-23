using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class HallImage
    {
        public int id { set; get; }
        public string Name { set; get; }
        [ForeignKey("HallId")]
        public Hall Hall { set; get; }
        public  int HallId { set; get; }
        [Required]
        public string URL { get; set; }

    }
}

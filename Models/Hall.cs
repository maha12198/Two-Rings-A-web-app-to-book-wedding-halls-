using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Hall
    {
        public Hall()
        {
            HallImages= new HashSet<HallImage>();
        }
        public ApplicationUser Manager { get; set; }
        public string ManagerId { get; set; }
        [Key]
        public int id { set; get; }

        [Required(ErrorMessage = "Please enter first name")]
        [Display(Name = "Name")]
        [StringLength(100)]
        public string Name { set; get; }

        [Required(ErrorMessage = "Please enter location")]
        public string Location { set; get; }
        [Required(ErrorMessage = "Please enter price")]
        public double Price { set; get; }
       
        [Required(ErrorMessage = "Please enter Hall Images")]
        public ICollection<HallImage> HallImages { set; get; }

        public IList<UserBookHall> UserBookHalls { get; set; }

        public IList<HallPackages> HallPackages { get; set; }


    }
}

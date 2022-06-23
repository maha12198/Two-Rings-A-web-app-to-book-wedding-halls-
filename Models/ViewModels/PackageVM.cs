using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models.ViewModels
{
    public class PackageVM
    {
        public int id { set; get; }
        [Required(ErrorMessage = "Please enter Name")]
        [Display(Name = "Name")]
        [StringLength(100)]
        public string Name { set; get; }
        [Required(ErrorMessage = "Please enter NUmber Of Persons")]
        [Display(Name = "Number Of Persons")]
        public int NumberOfPersons { set; get; }
        [Required(ErrorMessage = "Please choose")]
        [Display(Name = "Has Cake?")]
        public bool cake { set; get; }
        [Required(ErrorMessage = "Please choose")]
        [Display(Name = "Has Food?")]
        public bool food { set; get; }
        public Hall Hall { set; get; }
        [Required(ErrorMessage = "Please choose Hall")]
        [Display(Name = "Hall")]
        public int HallId { set; get; }

        [Required(ErrorMessage = "Please enter price")]
        [Display(Name = "Price")]
        public int price { set; get; }
    }
}

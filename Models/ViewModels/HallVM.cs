using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models.ViewModels
{
    public class HallVM
    {
        
        public int Id { set; get; }
       
        [Required(ErrorMessage = "Please enter Name")]
        [Display(Name = "Name")]
        [StringLength(100)]
        public string Name { set; get; }
        [Required(ErrorMessage = "Please enter Location")]
        [Display(Name = "Location")]
        [StringLength(100)]

        public string Location { set; get; }
        [Required(ErrorMessage = "Please enter Price")]
        [Display(Name = "Price")]
        public double Price { set; get; }
    
        public  string phone { get; set; }
        public string mangerid { get; set; }
    
        public string mangerName { set; get; }
      
        public List<HallImage> Gallery { get; set; }

        [Required(ErrorMessage = "Please enter Hall Photos")]
        [Display(Name = "Choose the Images of the Hall")]
      
        public IFormFileCollection HallPhotos { get; set; }
    }
}

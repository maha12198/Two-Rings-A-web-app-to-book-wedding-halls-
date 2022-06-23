using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class HallPackages
    {
       
        public int Id { set; get; }
        public string Name { set; get; }
        public int NumberOfPersons { set; get; }
        public int price { set; get; }
        public bool cake { set; get; }
        public bool food { set; get; }
        public Hall Hall { set; get; }
        public int HallId { set; get; }
    }
}

using System;

namespace Final_Project.Models
{
    public class UserBookHall
    {
        public ApplicationUser User { set; get; }
        public string UserId { get; set; }

        public Hall Hall { set; get; }
        public int HallId { set; get; }
        
        public HallPackages package { set; get; }
        public int PackageId { set; get; }
        public DateTime RequiredDay { set; get; }

        public string Phone { set; get; }

        public DateTime BookDay { set; get; }

        public bool approved { set; get; }

    }
}

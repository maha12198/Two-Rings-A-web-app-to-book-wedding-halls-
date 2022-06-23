using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;

namespace Final_Project.Models
{
    public class ApplicationUser:IdentityUser
    {
        public ApplicationUser()
        {
            Halls = new HashSet<Hall>();
        }
        public string First_Name { set; get; }
        public string Last_Name { set; get; }

        public ICollection<Hall> Halls { set; get; }
        public IList<UserBookHall> UserBookHalls { get; set; }
    }
}

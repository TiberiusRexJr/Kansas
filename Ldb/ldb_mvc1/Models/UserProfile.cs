using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ldb_mvc1.Models
{
    public class UserProfile
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="Enter First Name")]
        public string firstName { get; set; }

        public string middleName { get; set; }
        
        [Required(ErrorMessage ="Enter Last Name")]
        public string lastName { get; set; }

        public char sex { get; set; }

        [Required(ErrorMessage = "Enter Date of Birth ")]

        public DateTime dob { get; set; }

        public int age { get; set; }
        public int phone { get; set; }

        [Required(ErrorMessage = "Enter a Valid Email")]
        public string email { get; set; }
        public int department { get; set; }
        public string userPictureUrl { get; set; }

        public List<UserProfile> UserProfiles { get; set; }


    }
}

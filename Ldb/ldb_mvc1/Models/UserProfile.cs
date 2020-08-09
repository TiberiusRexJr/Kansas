using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Display(Name ="YoungGodz")]
        public string firstName { get; set; }

        public string middleName { get; set; }
        
        [Required(ErrorMessage ="Enter Last Name")]
        public string lastName { get; set; }

        public string sex { get; set; }

        [Required(ErrorMessage = "Enter Date of Birth ")]
        [DisplayName("Birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime dob { get; set; }

        public int age { get; set; }
        public int phone { get; set; }

        [Required(ErrorMessage = "Enter a Valid Email")]
        public string email { get; set; }
        public int department { get; set; }
        public string userPictureUrl { get; set; }

        public List<UserProfile> ShowAllUserProfiles { get; set; }

       
    }
}

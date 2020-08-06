using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ldb_mvc1.Models
{
    public class UserProfile
    {
        int id { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        char sex { get; set; }
        DateTime dob { get; set; }
        int age { get; set; }
        int phone { get; set; }
        string email { get; set; }
        int department { get; set; }
        string userPictureUrl { get; set; }


    }
}

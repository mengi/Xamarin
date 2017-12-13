using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10.Model
{
    public class UserModel
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public string userImageUrl { get; set; }
        public string userNationality { get; set; }
        public string userPhone { get; set; }
        public DateTime userBirthday { get; set; }
        public string userGender { get; set; }
        public string userBloodGroup { get; set; }
    }
}

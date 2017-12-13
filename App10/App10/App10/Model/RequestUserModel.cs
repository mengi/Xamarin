using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10.Model
{
    public class RequestUserModel
    {
        public string reUserName { get; set; }
        public string reUserPhone { get; set; }
        public string reUserMessage { get; set; }
        public string reUserService { get; set; }
        public DateTime reUserDay { get; set; }
        public int reState { get; set; }
    }
}

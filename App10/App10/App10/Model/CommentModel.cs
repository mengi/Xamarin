using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10.Model
{
    public class CommentModel
    {
        public int CommenId { get; set; }
        public string CommentUserName { get; set; }
        public string CommentServiceName { get; set; }
        public string CommentStar { get; set; }
        public string CommentDesc { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentImageUrl { get; set; }
    }
}

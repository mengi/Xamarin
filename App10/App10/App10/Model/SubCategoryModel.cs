using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10.Model
{
    public class SubCategoryModel
    {
        public int subId { get; set; }
        public int topReferenceId { get; set; }
        public string subTitle { get; set; }
        public string subDesc { get; set; }
        public string subImageUrl { get; set; }
    }
}

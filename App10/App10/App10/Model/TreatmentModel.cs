using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10.Model
{
    public class TreatmentModel
    {
        public int userId { get; set; }
        public string treatmentTitle { get; set; }
        public DateTime treatmentDate { get; set; }
        public string treatmentImageUrl { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo_TF.Entities
{
    public class Survey
    {
        public int Survey_id { get; set; }
        public DateTime Date  { get; set; }
        public int Result { get; set; }
        public virtual ICollection<Survey_options> Survey_options { get; set; }


    }
}

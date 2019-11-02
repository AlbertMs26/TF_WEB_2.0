using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_TF.Entities
{
    public class Option
    {
        public int Option_id { get; set; }
        public int Question_id { get; set; }
        public String Option_content { get; set; }
        public int Value { get; set; }
        public virtual Question Question {get; set; }
        public virtual ICollection<Survey_options> Survey_options { get; set; }
    }
}

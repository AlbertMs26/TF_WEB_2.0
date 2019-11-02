using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_TF.Entities
{
    public class Survey_options
    {
        public int Survey_option_id { get; set; }
        public int option_content { get; set; }
        public virtual  Option Options { get; set; }
        public virtual Survey Survey { get; set; }
    }
}

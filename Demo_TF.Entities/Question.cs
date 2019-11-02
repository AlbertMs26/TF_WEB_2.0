using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Demo_TF.Entities
{
    public class Question
    {
        public int Question_id { get; set; }
        public String Question_content { get; set; }
        public virtual ICollection<Option> Options { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class Skills
    {
        [Key]
        public int skillid { get; set; }
        public string name { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class Employees
    {
        [Key]
        public int employee_id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string manager { get; set; }
        public string wfm_manager { get; set; }

        public string email { get; set; }

        public string lockstatus { get; set; }
        public decimal experience { get; set; }
        public int profile_id { get; set; }
    }
}

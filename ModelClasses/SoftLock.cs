﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class SoftLock
    {
        [Key]
        public int lockid { get; set; }
        public int employee_id { get; set; }
        public string? manager { get; set; }
        public DateTime reqdate { get; set; }

        public string? status { get; set; }
        public DateTime lastupdated { get; set; }

        
        public string? requestmessage { get; set; }
        public string? wfmremark { get; set; }
        public string? managerstatus { get; set; }
        public string? mgrstatuscomment { get; set; }
        public DateTime mgrlastupdate { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShieldSafety.Data.Models
{
    public class Customer : BaseEntity
    {
     
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }
        public DateTime DOB { get; set; }
    }
}

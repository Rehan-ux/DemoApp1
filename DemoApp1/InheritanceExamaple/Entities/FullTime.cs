﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1.InheritanceExamaple.Entities
{
    internal class FullTime :Employeed
    {
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
    }
}

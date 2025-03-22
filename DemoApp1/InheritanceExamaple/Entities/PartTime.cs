using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1.InheritanceExamaple.Entities
{
    internal class PartTime :Employeed

    {
        public decimal HourRate { get; set; }
        public int CountOfHour { get; set; }
    } 
}

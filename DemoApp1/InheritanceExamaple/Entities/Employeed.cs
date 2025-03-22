using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1.InheritanceExamaple.Entities
{
    //[Table("Empolyees")]
    internal class Employeed //Conttainer
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string? Address { get; set; }
    }
        



}

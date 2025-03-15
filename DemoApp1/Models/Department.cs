using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1.Models
{
    internal class Department
    {
        public int  DepartmentId { get; set; }
        public required string Name { get; set; }
        public DateOnly CreationDate { get; set; }
        //public int ManagerId { get; set; }
        //[ForeignKey(nameof(Manager))]

        public int DepartmentManagerId { get; set; }
        //navigation proparty [one]
        // EF core ; Department must has one emplyee [manager]=> [total part
        [InverseProperty("ManagedDepartment")]
        public Emplyee Manager { get; set; }
        //public Address Address { get; set; }
        // navigation property [many]
        //[InverseProperty("Department")]
        public ICollection<Emplyee> Employees { get; set; } = new HashSet<Emplyee>(); //الموظفين اللي شغالين عندي فيEmplyee
        //public Department()
        //{
        //   Employees=new HashSet<Emplyee>();
        //}

    }
}

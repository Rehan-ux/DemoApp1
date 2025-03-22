using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1.Models
{
   // [Table("Department")]
    public class Department
    {
       // [Key]
        public int  DepartmentId { get; set; }
        public required string Name { get; set; }
        public DateOnly CreationDate { get; set; }
        //public int ManagerId { get; set; }
       
       [ForeignKey(nameof(Manager))]
       

        public int DepartmentManagerId { get; set; }
        //navigation proparty [one]
        // EF core ; Department must has one emplyee [manager]=> [total part
        
        [InverseProperty("ManagerDepartment")]
        
        public virtual Emplyee Manager { get; set; }
        public string Address { get; set; }
        // navigation property [many]

        public virtual ICollection<Emplyee> Employees { get; set; }  //الموظفين اللي شغالين عندي فيEmplyee
        //public Department()
        //{
        //   Employees=new HashSet<Emplyee>();
        //}

    }
}

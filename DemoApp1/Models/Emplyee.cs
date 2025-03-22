using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1.Models
{
    //internal class Emplyee
    //{
    //    public int Id { get; set; }
    //    public string? Name { get; set; }
    //    public decimal Salary { get; set; }
    //    public int Age { get; set; }    


    //}
    #region DataAnnotation
    [Table("Emplyees")]
    public class Emplyee
    {
        internal object Name;

        [Key]
        public int EmpId { get; set; }
       // [Column("EmplyeeName",TypeName ="Varchar")]
       // [MaxLength(50)]
        public string? EmpName { get; set; }
       // [Column("EmplyeeSalary")]
        public decimal Salary { get; set; }
        
        public int? Age { get; set; }

        [DataType(DataType.PhoneNumber)]

        public string phoneNumber { get; set; }
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        public Address Address { get; set; }

        //navigation property [one]
        //Ef core : Emplyee may have manage department or not [partial participation]
     
       [InverseProperty("Manager")] //manger
       

       public virtual Department? ManagerDepartment { get; set; }
       
        public int? DepartmentId {  get; set; }
        //navigation proparty [one]


        [InverseProperty("Employees")]


        // [ForeignKey("Hamada")] //لوعايز اغير اسم ID وملوش تاثير علي الاتا 
        public virtual Department ?Department { get; set; }




    }
    #endregion
}

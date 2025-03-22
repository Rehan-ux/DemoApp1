using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
       // public string? LName { get; set; }
        public string Adress { get; set; }
        public int? Age { get; set; }
        // public int DepartmentId { get; set; }
        //public ICollection<Course> Courses { get; set; }
        public virtual ICollection<StudentCourse> studentCourses { get; set; }
    }
}

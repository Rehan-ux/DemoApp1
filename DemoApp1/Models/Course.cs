using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<StudentCourse> studentCourses { get; set; }
        //public ICollection<Student> Students { get; set; } = new List<Student>();
        //public string? description { get; set; }
        //public int? duration { get; set; }
    }
}

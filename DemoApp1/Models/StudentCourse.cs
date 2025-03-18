using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1.Models
{
    [PrimaryKey(nameof(StudentId),nameof(CourseId))]
    internal class StudentCourse
    {
        public int StudentId { get; set; }

        public int CourseId { get; set; }
        public int Crad { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }  //دي بتاعت ال one ممكن اكتبها وممكن لا 
    }
}

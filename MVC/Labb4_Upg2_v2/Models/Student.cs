using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labb4_Upg2_v2.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PersonNumber { get; set; }
        public string Adress { get; set; }
        public List<Grade> Grades { get; set; }
    }
}
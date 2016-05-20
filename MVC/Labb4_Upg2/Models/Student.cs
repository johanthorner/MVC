using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labb4_Upg2.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Grade> Grades { get; set; }

    }
}
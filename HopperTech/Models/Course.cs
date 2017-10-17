using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HopperTech.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CourseHours { get; set; }
        public string Room { get; set; }
        public string Department { get; set; }

    }
}
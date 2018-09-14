using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Week4InClass.Shared.Enums;
using Week4InClass.Shared.ViewModels;

namespace Week4Inclass.Models
{
    public class SemesterModel
    {
        public int Year { get; set; }
        public SemesterEnum Semester { get; set; }
        [DisplayName ("Semester Name:")]
        public string SemesterName => Semester.ToString();
        public List<CourseViewModel> Courses { get; set; }
    }
}
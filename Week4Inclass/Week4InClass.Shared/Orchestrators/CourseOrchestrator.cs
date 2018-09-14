using System.Collections.Generic;
using Week4InClass.Shared.Orchestrators.Interfaces;
using Week4InClass.Shared.ViewModels;

namespace Week4InClass.Shared.Orchestrators
{
    public class CourseOrchestrator : ICourseOrchestrator
    {
        public List<CourseViewModel> GetAllCourses()
        {
            var courses = new List<CourseViewModel>
            {
                new CourseViewModel
                {
                    Department = "CIS",
                    CourseNumber = 174,
                    CourseName = "Advanced C#",
                    Capacity = 25
                },
                new CourseViewModel
                {
                    Department = "CIS",
                    CourseNumber = 169,
                    CourseName = "Intro to C#",
                    Capacity = 15
                }
            };

            return courses;
        }
    }
}

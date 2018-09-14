using System.Collections.Generic;
using Week4InClass.Shared.ViewModels;

namespace Week4InClass.Shared.Orchestrators.Interfaces
{
    interface ICourseOrchestrator
    {
        List<CourseViewModel> GetAllCourses();
    }
}

using System.Web.Mvc;
using Week4Inclass.Models;
using Week4InClass.Shared.Enums;
using Week4InClass.Shared.Orchestrators;

namespace Week4Inclass.Controllers
{
    public class UserRegistrationController : Controller
    {
        // GET: UserRegistration
        public ActionResult Index()
        {
            var courseOrchestrator = new CourseOrchestrator();

            var semesterModel = new SemesterModel
            {
                Courses = courseOrchestrator.GetAllCourses(),
                Semester = SemesterEnum.Spring,
                Year = 2019
            };

            return View(semesterModel);
        }
    }
}
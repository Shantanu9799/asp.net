using RoutingTraditionalWay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingTraditionalWay.Controllers
{
    [RoutePrefix("students")]
    public class StudentController : Controller
    {
        // GET: Student
        [Route("")]
        public ActionResult GetAllStudents()
        {
            var students = Students();
            return View(students);
        }

        [Route("{id:int}")] // with constrains for optimization of errors
        public ActionResult GetStudent(int id)
        {
            var student = Students().FirstOrDefault(x => x.Id == id);
            return View(student);
        }

        [Route("{id}/address")]
        public ActionResult GetStudentAddress(int id)
        {
            var studentAdd = Students().Where(x => x.Id == id).Select(x => x.Address).FirstOrDefault();
            return View(studentAdd);
        }

        [Route("{id}")]
        public string myString(string id)
        {
            return id;
        }

        [Route("~/about-us")]
        // It's allowed to add more than one route for one action method
        [Route("~/aboutus")]
        public string AboutUs()
        {
            return "Helooooooooooooooooooooooooooooooooo !!!  from about-us.";
        }

        // but one route can not be matched with more than one action method

        private List<Student> Students()
        {
            return new List<Student>()
            {
                new Student
                {
                    Id = 1,
                    Name = "Shantanu",
                    Class = "4th Year",
                    Address = new Address
                    {
                        HomeNumber = "N156",
                        HomeAddress = "Gopalbera, Khandaghosh, Purba Bardhaman",
                        City = "Burdwan"
                    }
                },
                new Student
                {
                    Id = 2,
                    Name = "Somnath Bera",
                    Class = "5th Year",
                    Address = new Address
                    {
                        HomeNumber = "xxx-xxx",
                        HomeAddress = "Tarkeshwar, Hooghly",
                        City = "Tarkeshwar"
                    }
                },
                new Student
                {
                    Id = 3,
                    Name = "Rohit Gupta",
                    Class = "6th Year",
                    Address = new Address
                    {
                        HomeNumber = "yyy-yyy",
                        HomeAddress = "Bansdroni, Kolkata",
                        City = "Kolkata"
                    }
                },
            };
        }
    }
}
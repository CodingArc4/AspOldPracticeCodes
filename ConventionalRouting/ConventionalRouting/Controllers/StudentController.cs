using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConventionalRouting.Models;

namespace ConventionalRouting.Controllers
{
    public class StudentController : Controller
    {
        [Route("students")]
        public ActionResult GetAllStudent()
        {
            var students = Students();
            return View(students);
        }

        [Route("students/{id}")]
        public ActionResult GetStudent(int id)
        {
            var student = Students().FirstOrDefault(x => x.Id == id);
            return View(student);
        }

        [Route("students/{id}/address")]
        public ActionResult GetStudentAddress(int id)
        {
            var studentAddress = Students().Where(x => x.Id == id).Select(x => x.Address).FirstOrDefault();
            return View(studentAddress);
        }

        [Route("{id}")]
        public string MyString(string id)
        {
            return id;
        }

        private List<Student> Students()
        {
            return new List<Student>() {
                 new Student
                 {
                    Id = 1,
                    Name = "ali",
                    Class = "Kindergarden",
                    Address = new Address()
                    {
                        HomeNumber = "Student 1",
                        Address1 = "ada boulevard",
                        City = "Edmonton"
                    }
                 },
                 new Student
                 {
                    Id = 2,
                    Name = "ali khan",
                    Class = "Kindergarden",
                    Address = new Address()
                    {
                        HomeNumber = "Student 2",
                        Address1 = "ada boulevard",
                        City = "Calgary"
                    }
                 },
                 new Student
                 {
                    Id = 3,
                    Name = "Hamza",
                    Class = "Kindergarden",
                    Address = new Address()
                    {
                        HomeNumber = "Student 3",
                        Address1 = "ada boulevard",
                        City = "New York"
                    }
                 },
                 new Student
                 {
                    Id = 4,
                    Name = "Qasim",
                    Class = "Kindergarden",
                    Address = new Address()
                    {
                        HomeNumber = "Student 4",
                        Address1 = "ada boulevard",
                        City = "Peshawar"
                    }
                 }
            };
        }
    }
}
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotNetMVC
{
    public class RookiesController : Controller
    {
        List<PersonModel> persons = new List<PersonModel>(){
            new PersonModel("nguyen van", "A", new DateTime(1999, 09, 24), "nam", 1234567890, "HCM", 21, false),
            new PersonModel("nguyen van", "B", new DateTime(1999, 09, 24), "nam", 1234567890, "QN", 21, true),
            new PersonModel("nguyen van", "C", new DateTime(1997, 09, 24), "nam", 1234567890, "HN", 23, false),
            new PersonModel("nguyen van", "D", new DateTime(1998, 09, 24), "nam", 1234567890, "QN", 22, true),
            new PersonModel("nguyen van", "E", new DateTime(1999, 09, 24), "nam", 1234567890, "HCM", 21, false),
            new PersonModel("nguyen van", "F", new DateTime(1999, 09, 24), "nam", 1234567890, "TB", 21, true),
            new PersonModel("nguyen van", "G", new DateTime(1991, 09, 24), "nam", 1234567890, "ST", 29, false),
            new PersonModel("nguyen van", "H", new DateTime(1999, 09, 24), "nam", 1234567890, "HCM", 21, true),
            new PersonModel("nguyen van", "I", new DateTime(1991, 09, 24), "nam", 1234567890, "HCM", 29, false),
            new PersonModel("nguyen van", "K", new DateTime(2000, 09, 24), "nam", 1234567890, "HN", 20, true),
            new PersonModel("nguyen van", "A", new DateTime(2003, 09, 24), "nam", 1234567890, "HCM", 18, false),
            new PersonModel("tran thi", "B", new DateTime(1999, 09, 24), "nu", 1234567890, "HCM", 21, false),
            new PersonModel("tran thi", "C", new DateTime(2003, 09, 24), "nu", 1234567890, "TB", 18, true),
            new PersonModel("tran thi", "D", new DateTime(1999, 09, 24), "nu", 1234567890, "DN", 21, false),
            new PersonModel("tran thi", "E", new DateTime(1998, 09, 24), "nu", 1234567890, "TS", 22, true),
            new PersonModel("tran thi", "F", new DateTime(1999, 09, 24), "nu", 1234567890, "HCM", 23, false),
            new PersonModel("tran thi", "G", new DateTime(1997, 09, 24), "nu", 1234567890, "BN", 23, true),
            new PersonModel("tran thi", "H", new DateTime(1999, 09, 24), "nu", 1234567890, "HN", 21, false),
            new PersonModel("tran thi", "I", new DateTime(2001, 09, 24), "nu", 1234567890, "HCM", 18, true),
            new PersonModel("tran thi", "K", new DateTime(1999, 09, 24), "nu", 1234567890, "HCM", 21, false),

        };
        public IActionResult Index()
        {
            List<PersonModel> model = persons.Where(item => item.gender == "nam").ToList();
            return View(model);

        }
        public IActionResult Csv()
        {
            var builder = new StringBuilder();
            builder.AppendLine("firstName,lastName");
            foreach (var person in persons)
            {
                builder.AppendLine($"{person.firstName},{person.lastName}");
            }
            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "person.csv");
        }
        public IActionResult GetMaleMember()
        {

            List<PersonModel> model = persons.Where(item => item.gender == "nam").ToList();
            return View(model);
        }
        public IActionResult GetOldest()
        {
            var oldest = persons.Select(item => item.age).Max();
            List<PersonModel> model = persons.Where(item => item.age == oldest).ToList();
            return View(model);

        }
        public IActionResult GetFullName()
        {
            List<PersonModel> model = persons.ToList();
            return View(model);
        }
        public IActionResult YearOfBirth2000()
        {
            List<PersonModel> model = persons.Where(item => item.dateOfBirth.Year == 2000).ToList();
            return View(model);
        }
        public IActionResult YearOfBirth2000up()
        {
            List<PersonModel> model = persons.Where(item => item.dateOfBirth.Year > 2000).ToList();
            return View(model);
        }
        public IActionResult YearOfBirth2000down()
        {
            List<PersonModel> model = persons.Where(item => item.dateOfBirth.Year < 2000).ToList();
            return View(model);
        }
    }
}
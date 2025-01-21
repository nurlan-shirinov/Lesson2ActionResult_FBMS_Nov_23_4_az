using Lesson2ActionResult.Entites;
using Lesson2ActionResult.Models;
using Lesson2ActionResult.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Linq;

namespace Lesson2ActionResult.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalculate _calculate1;
        private readonly ICalculate _calculate2;

        public HomeController(ICalculate calculate1, ICalculate calculate2)
        {
            _calculate1 = calculate1;
            _calculate2 = calculate2;
        }

        public string Index()
        {
            return $"Hello From Index Action {_calculate1.MyCalculate(100)} - {_calculate2.MyCalculate(100)}";
        }

        public IActionResult Index2()
        {
            return View();
        }

        public ViewResult Employee1()
        {
            List<Employee> employees = new()
            {
                new Employee
                {
                    Id = 1,
                    CityId = 1,
                    Firstname="Aqshin",
                    Lastname = "Ahmedli"
                },

                new Employee
                {
                    Id = 2,
                    CityId = 2,
                    Firstname="Nizami",
                    Lastname = "Amirov"
                },
                new Employee
                {
                    Id = 3,
                    CityId = 2,
                    Firstname="Ali",
                    Lastname = "Aliyev"
                }
            };

            return View(employees);
        }

        //public ViewResult Employee2()
        //{
        //    List<Employee> employees = new()
        //    {
        //        new Employee
        //        {
        //            Id = 1,
        //            CityId = 1,
        //            Firstname="Aqshin",
        //            Lastname = "Ahmedli"
        //        },

        //        new Employee
        //        {
        //            Id = 2,
        //            CityId = 2,
        //            Firstname="Nizami",
        //            Lastname = "Amirov"
        //        },
        //        new Employee
        //        {
        //            Id = 3,
        //            CityId = 2,
        //            Firstname="Ali",
        //            Lastname = "Aliyev"
        //        }
        //    };

        //    return View(employees);

        //}

        public ViewResult Employee2()
        {
            List<Employee> employees = new()
            {
                new Employee
                {
                    Id = 1,
                    CityId = 1,
                    Firstname="Aqshin",
                    Lastname = "Ahmedli"
                },

                new Employee
                {
                    Id = 2,
                    CityId = 2,
                    Firstname="Nizami",
                    Lastname = "Amirov"
                },
                new Employee
                {
                    Id = 3,
                    CityId = 2,
                    Firstname="Ali",
                    Lastname = "Aliyev"
                }
            };

            List<string> cities = new List<string>() { "Baku", "Antalya", "London" };

            var vm = new EmployeeViewModel()
            {
                Employee = employees,
                Cities = cities
            };

            return View(vm);

        }

        public IActionResult Index4()
        {
            return Ok();
        }

        public IActionResult Index5()
        {
            return NotFound();
        }


        public IActionResult Index6()
        {
            return BadRequest();
        }

        public IActionResult Index7()
        {
            return Redirect("/home/index");
        }

        public IActionResult Index8()
        {
            return RedirectToAction("employee1");
        }

        public IActionResult Index9()
        {
            var routValue = new RouteValueDictionary(
                new { action = "Employee1", controller = "Home" });

            return RedirectToRoute(routValue);
        }

        public JsonResult GetJson()
        {
            List<Employee> employees = new()
            {
                new Employee
                {
                    Id = 1,
                    CityId = 1,
                    Firstname="Aqshin",
                    Lastname = "Ahmedli"
                },

                new Employee
                {
                    Id = 2,
                    CityId = 2,
                    Firstname="Nizami",
                    Lastname = "Amirov"
                },
                new Employee
                {
                    Id = 3,
                    CityId = 2,
                    Firstname="Ali",
                    Lastname = "Aliyev"
                }
            };

            return Json(employees);
        }

        //Route param
        public JsonResult Index10(int id = -1)
        {
            List<Employee> employees = new()
            {
                new Employee
                {
                    Id = 1,
                    CityId = 1,
                    Firstname="Aqshin",
                    Lastname = "Ahmedli"
                },

                new Employee
                {
                    Id = 2,
                    CityId = 2,
                    Firstname="Nizami",
                    Lastname = "Amirov"
                },
                new Employee
                {
                    Id = 3,
                    CityId = 2,
                    Firstname="Ali",
                    Lastname = "Aliyev"
                }
            };

            if (id == -1)
                return Json(employees);
            else
            {
                var data = employees.FirstOrDefault(e => e.Id == id);
                return Json(data);
            }
        }

        //Query param
        public JsonResult Index11(string key , int id = -1)
        {
            List<Employee> employees = new()
            {
                new Employee
                {
                    Id = 1,
                    CityId = 1,
                    Firstname="Aqshin",
                    Lastname = "Ahmedli"
                },

                new Employee
                {
                    Id = 2,
                    CityId = 2,
                    Firstname="Nizami",
                    Lastname = "Amirov"
                },
                new Employee
                {
                    Id = 3,
                    CityId = 2,
                    Firstname="Ali",
                    Lastname = "Aliyev"
                }
            };

            if (id == -1)
            {
                var data = employees.Where(e=>e.Firstname.Contains(key));
                return Json(data);
            }
            else
            {
                var data = employees.Where(e => e.Id == id || e.Firstname.Contains(key));
                return Json(data);
            }
        }

    }
}
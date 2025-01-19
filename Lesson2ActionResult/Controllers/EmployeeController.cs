using Lesson2ActionResult.Entites;
using Lesson2ActionResult.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Lesson2ActionResult.Controllers
{
    public class EmployeeController : Controller
    {
        //hecbir http ver istifade etmedikde default olaraq GET sorgusu olur.
        [HttpGet]
        public IActionResult Add()
        {
            var vm = new EmployeeAddViewModel()
            {
                Employee = new Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{ Text="Baku" , Value="1"},
                    new SelectListItem { Text = "Gence" ,Value = "2"},
                    new SelectListItem { Text = "Sumqayit" ,Value = "3"},
                    new SelectListItem { Text = "Agdam" ,Value = "4"}
                }
            };

            return View(vm);
        }

        //[HttpPost]
        //public IActionResult Add(EmployeeAddViewModel viewModel)
        //{
        //    var vm = new EmployeeAddViewModel()
        //    {
        //        Employee = new Employee()
        //    };

        //    return View(vm);
        //}

        [HttpPost]
        public IActionResult Add(EmployeeAddViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/home/index");
            }

            return View(viewModel);
        }
    }
}

using Lesson2ActionResult.Entites;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Lesson2ActionResult.Models
{
    public class EmployeeAddViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}

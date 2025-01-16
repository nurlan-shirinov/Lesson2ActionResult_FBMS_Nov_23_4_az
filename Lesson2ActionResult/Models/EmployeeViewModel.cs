using Lesson2ActionResult.Entites;
using System.Collections.Generic;

namespace Lesson2ActionResult.Models
{
    public class EmployeeViewModel
    {
        public List<Employee> Employee { get; set; }
        public List<string> Cities { get; set; }
    }
}

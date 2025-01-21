using Lesson2ActionResult.Entites;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson2ActionResult.TagHelpers
{
   
    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper : TagHelper
    {
        public List<Employee> _employees;

        public EmployeeListTagHelper()
        {
            _employees = new List<Employee>()
            {
                  new Employee
                {
                    Id = 1,
                    CityId = 1,
                    Firstname="Mahir",
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
                },
                       new Employee
                {
                    Id = 1,
                    CityId = 1,
                    Firstname="Fazil",
                    Lastname = "Ahmedli"
                },

                new Employee
                {
                    Id = 2,
                    CityId = 2,
                    Firstname="Kamal",
                    Lastname = "Amirov"
                }
            };
        }

        private const string SortAttribute = "sort";
        [HtmlAttributeName(SortAttribute)]
        public string SortOrder { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            IEnumerable<Employee> query;
            switch (SortOrder.ToLower())
            {
                case "a-z":
                    query = _employees.OrderBy(e=>e.Firstname);
                    break;
                case "z-a":
                    query = _employees.OrderByDescending(e=>e.Firstname);
                    break;
                default:
                    query = _employees;
                    break;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var item in query)
            {
                sb.AppendFormat("<h2><a href='/employee/detil/{0}'>{1}</a></h2>" , item.Id , item.Firstname);
            }

            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}
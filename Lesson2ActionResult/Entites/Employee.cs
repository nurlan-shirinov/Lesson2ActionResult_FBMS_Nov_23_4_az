using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lesson2ActionResult.Entites
{
    public class Employee
    {
        [Range(1,200)]
        public int Id { get; set; }

        [DisplayName("User name")]
        [Required]
        public string Firstname { get; set; }

        [DisplayName("User Surname")]
        [Required]
        public string Lastname { get; set; }

        public int CityId { get; set; }
    }
}
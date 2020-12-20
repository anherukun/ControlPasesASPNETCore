using System;
using System.ComponentModel.DataAnnotations;

namespace PassoutASP.Models
{
    public class Employe
    {
        [Key] public string EmployeUID { get; set; }
        [Required] public int EmployeID { get; set; }
        [Required] public string Name { get; set; }
    }
}

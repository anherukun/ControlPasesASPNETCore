using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security;

namespace PassoutASP.Models
{
    public class User
    {
        [Key] public string UserId { get; set; }

        [Required] public int EmployeId { get; set; }

        public SecureString Password { get; set; }

        [Required] public string FirstName { get; set; }

        [Required] public string LastName { get; set; }

        [Required] public string Rol { get; set; }

        public string LoginToken { get; set; }

        public DateTime LastLogin { get; set; }

        public bool RequirePasswordChange { get; set; }
    }

    public class UserRol
    {
        public const string GATE = "CASETA";
        public const string MANAGER = "SUPERVISOR";
        public const string ITMANAGER = "SOPORTE_TI";
        public const string OPIP = "OFICIAL_PROTECCION";
    }
}

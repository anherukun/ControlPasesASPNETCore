using System;
namespace PassoutASP.Application
{
    public class ApplicationManager
    {
        /// <summary>
        /// Genera un GUID aleatorio
        /// </summary>
        public static string GenerateGUID => Guid.NewGuid().ToString().ToUpper();
    }
}

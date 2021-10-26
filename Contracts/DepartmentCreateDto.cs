using System.ComponentModel.DataAnnotations;

namespace Contracts
{
    public class DepartmentCreateDto
    { 
        public string GroupeName { get; set; }

        public string DepartmentName { get; set; }

        public string DepartmentAdresse { get; set; }
    }
}
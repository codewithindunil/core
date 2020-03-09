using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required]

        public String FullName { get; set; }
        [Column(TypeName = "varchar(100)")]

        public String EmpCode { get; set; }
        [Column(TypeName = "varchar(100)")]

        public String Position { get; set; }
        [Column(TypeName = "varchar(100)")]

        public String OfficeLocation { get; set; }
       

    }
}

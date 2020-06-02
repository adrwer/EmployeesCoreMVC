﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesCoreMVC.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string EmpCode { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string JobTitle { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Department { get; set; }
    }
}
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeEditViewModel : EmployeeCreateViewModel
    {
        public EmployeeEditViewModel(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Email = employee.Email;
            this.Department = employee.Department;
            this.ExistingPhotoPath = employee.PhotoPath;
        }

        public int Id { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}

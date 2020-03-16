using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _emplyeeReopiory;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _emplyeeReopiory = employeeRepository;
        }

        public string Index()
        {
            return _emplyeeReopiory.GetEmployee(1).Name;
        }
    }
}

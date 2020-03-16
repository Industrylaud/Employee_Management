using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id=1, Name = "elo1", Department = "HR", Email = "elo1@mail.pl"},
                new Employee() {Id = 2, Name = "hej2", Department = "IT", Email = "hej2@mail.com"},
                new Employee() {Id = 3, Name = "dupa3", Department = "IT", Email = "dupa3@mail.net"}
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}

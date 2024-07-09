using Microsoft.EntityFrameworkCore;

using MVCAjax.Interfaces;
using MVCAjax.Models;

namespace MVCAjax.Services
{
    public class EmployeeService : IEmployee
    {
        private DBCtx _context;
        public EmployeeService()
        {
            _context = new DBCtx();
        }
        public async Task<List<Employee>> GetAllEmployees()
        {
            // This line will return list of Employees
            var employees = await _context.Employees.ToListAsync();
            return employees;
        }       
      
    }
}

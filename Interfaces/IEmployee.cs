using MVCAjax.Models;


namespace MVCAjax.Interfaces
{
    public interface IEmployee
    {
        // Return list of Employees
        Task<List<Employee>> GetAllEmployees();
        
        
    }
}

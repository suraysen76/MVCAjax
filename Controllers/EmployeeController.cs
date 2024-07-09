using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MVCAjax.Interfaces;
using MVCAjax.Models;
using Newtonsoft.Json;
using System.Web.Mvc;
using System.Web.WebPages.Html;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using JsonResult = Microsoft.AspNetCore.Mvc.JsonResult;
using SelectListItem = System.Web.Mvc.SelectListItem;

namespace MVCAjax.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployee _employeeService;
        public EmployeeController(IEmployee employeeService)
        {
            _employeeService = employeeService;
        }
        // GET: EmployeeController
        public Microsoft.AspNetCore.Mvc.ActionResult Index()
        {
            

            return View();
            
        }

        public async Task<string> GetEmployees()
        {
            //List<Employee> employees = new List<Employee>();
            var employees = await _employeeService.GetAllEmployees();
            var jsonStr= JsonConvert.SerializeObject(employees);
            return jsonStr;
            //return (IEnumerable<JsonResult>)Json(employees);

            //return Json(employees, JsonRequestBehavior.AllowGet);
        }


    }
}

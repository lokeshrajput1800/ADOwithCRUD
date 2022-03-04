using ADOwithCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADOwithCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeesDataAccess dataAccess;
        public EmployeeController()
        {
            dataAccess = new EmployeesDataAccess();
        }

        public IActionResult Index()
        {
            var emp = dataAccess.GetEmployees();
            return View(emp);
        }
    }
}

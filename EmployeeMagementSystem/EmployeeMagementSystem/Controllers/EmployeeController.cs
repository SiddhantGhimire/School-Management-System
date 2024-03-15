using Microsoft.AspNetCore.Mvc;
using EmployeeMagementSystem.Models.ViewModels;
using EmployeeMagementSystem.Models;

namespace EmployeeMagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;




        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

        }


        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AddEmployee()
        {
            var viewModel = new AddEmployeeViewModel();
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddEmployee(AddEmployeeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

                Employee newEmployee = new Employee
                {
                    Name = viewModel.Name,
                    ImageUrl = viewModel.ImageUrl,
                    PhoneNumber = viewModel.PhoneNumber,
                    Address = viewModel.Address,
                    Email = viewModel.Email,
                };
                _employeeRepository.AddEmployee(newEmployee);
            }
            return View();
        }


    }
}

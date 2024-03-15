namespace EmployeeMagementSystem.Models.ViewModels
{
    public class EmployeeListViewModel
    {

        public IEnumerable<Employee> Employees { get; }

        public EmployeeListViewModel(IEnumerable<Employee> employees)
        {

           Employees= employees;
        }
    }
}

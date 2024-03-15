namespace EmployeeMagementSystem.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly EmployeeeManagementSystemDbContext _employeeManagementSystemDbContext;

        public EmployeeRepository(EmployeeeManagementSystemDbContext EmployeeManagementSystemDbContext)
        {

            _employeeManagementSystemDbContext = EmployeeManagementSystemDbContext;
        }

        public void AddEmployee(Employee employee)
        {

            _employeeManagementSystemDbContext.Employees.Add(employee);
            _employeeManagementSystemDbContext.SaveChanges();
        }
    }
}

namespace WP01.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private static List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>(){
            new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@CDACtech.com" },
            new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@CDACtech.com" },
            new Employee() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@CDACtech.com" },
    };
        }
       
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

       
    }
}


using System.Collections.Generic;
namespace WP01.Models
{



    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();
    }

}

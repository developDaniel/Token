using JWT.Models;

namespace JWT.Constants
{
    public class EmployeeConstants
    {
        public static List<EmployeeModel> GetEmployees = new List<EmployeeModel>()
        {
            new EmployeeModel() {FirstName = "cesar", LastName ="gonzalez", Email = "cesargo@gmail.com"},
            new EmployeeModel() {FirstName = "daniel", LastName ="alay", Email = "daniel@gmail.com"}
        };
    }
}

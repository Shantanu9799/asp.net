using System.Web.Mvc;

namespace ControllerInMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        
        // passing parameter, through url

        // single parameter
        public string employeeProfile(int id)
        {
            // creating an empty string
            string profile = string.Empty;

            // adding some condition
            if(id == 1)
            {
                profile = "Employee profile 1";
            }
            else if(id == 2)
            {
                profile = "Employee profile 2";
            } else
            {
                profile = "No record found !!!!";
            }
            return profile;
        }
        // url -> https://localhost:44388/employee/employeeProfile?id=2


        // More than One parameter
        public string employeeAddress(int id, string department)
        {
            return "id = " + id + " Department = " + department;
        }
        //url -> https://localhost:44388/employee/employeeAddress?id=1&department=%22test%22


        // nullable parameter
        public string EmployeeAddressNullable(int id, string? department = "-")
        {
            return "id = " + id + " Department = " + department;
        }

    }
}
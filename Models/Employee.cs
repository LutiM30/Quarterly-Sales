namespace Quarterly_Sales.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateOfHire { get; set; }
        public int ManagerId { get; set; }
    }
}

namespace Quarterly_Sales.Models
{
    public class Sales
    {
        public int SalesId { get; set; }
        public int Quarter { get; set; }
        public int Year { get; set; }
        public decimal Amount { get; set; }
        public int EmployeeId { get; set; }
        public required Employee Employee { get; set; }
    }
}

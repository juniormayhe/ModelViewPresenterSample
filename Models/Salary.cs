namespace ModelViewPresenterSample.Models
{
    public class Salary
    {

        public double GrossSalary { get; set; }

        public double Discounts { get; set; }

        public double CalculateNetSalary()
        {
            return GrossSalary - Discounts;
        }
    }
}

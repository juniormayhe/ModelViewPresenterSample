using ModelViewPresenterSample.Models;
using ModelViewPresenterSample.Views;

namespace ModelViewPresenterSample.Presenters
{
    /// <summary>
    /// holds logic to calculate salary using user data from view
    /// </summary>
    public class SalaryPresenter
    {
        /// <summary>
        /// user input data provided on view
        /// </summary>
        private readonly ISalary salaryView;

        public SalaryPresenter(ISalary salaryView)
        {
            this.salaryView = salaryView;
        }

        public void CalculateNetSalary() {
            // set model with input data entered by user on View
            Salary salary = new Salary();
            salary.GrossSalary = double.Parse(this.salaryView.GrossSalaryText);
            salary.Discounts = double.Parse(this.salaryView.DiscountsText);

            this.salaryView.CalculatedNetSalaryText = salary.CalculateNetSalary().ToString("N2");
        }
        
    }
}

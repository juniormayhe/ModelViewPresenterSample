namespace ModelViewPresenterSample.Views
{
    /// <summary>
    /// Represents user input on View
    /// </summary>
    public interface ISalary
    {
        string GrossSalaryText { get; set; }
        string DiscountsText { get; set; }

        string CalculatedNetSalaryText { get; set; }
    }
}

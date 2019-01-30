using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelViewPresenterSample.Presenters;
using ModelViewPresenterSample.Views;

namespace ModelViewPresenterSample
{
    public partial class frmNetSalaryCalculation : Form, ISalary
    {
        public frmNetSalaryCalculation()
        {
            InitializeComponent();
        }

        public string GrossSalaryText { get => nudGrossSalary.Value.ToString(); set => nudGrossSalary.Value = decimal.Parse(value); }
        public string DiscountsText { get => nudDiscounts.Value.ToString(); set => nudDiscounts.Value = decimal.Parse(value); }
        public string CalculatedNetSalaryText { get => lblNetSalary.Text; set => lblNetSalary.Text = value; }

        private void BtnCalculateNetSalary_Click(object sender, EventArgs e)
        {
            // inject the view ISalary with user input into presenter with
            var salaryPresenter = new SalaryPresenter(this);

            salaryPresenter.CalculateNetSalary();
            
        }
    }
}

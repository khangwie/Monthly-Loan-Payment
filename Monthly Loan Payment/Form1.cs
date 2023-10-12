using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monthly_Loan_Payment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double PurchasePrice = 0.0;
            double DownPayment = 0.0;
            double InterestRate = 0.0;
            int LoanTerm = 0;

            if (string.IsNullOrEmpty(txtPurchasePrice.Text))
            { 
                MessageBox.Show("Purchase Price is required.", "Error");
                return;
            }

            if (string.IsNullOrEmpty(txtDownPayment.Text)) 
            {
                MessageBox.Show("Down Payment is required.", "Error");
                return;
            }

            if (string.IsNullOrEmpty (txtInterestRate.Text))
            {
                MessageBox.Show("Annual Interest Rate is required.", "Error");
                return;

            }

            if (string.IsNullOrEmpty(txtLoanTerm.Text))
            {
                MessageBox.Show("Term is required.", "Error");
                return;

            }


            try
            {
                PurchasePrice = Convert.ToDouble(txtPurchasePrice.Text);
                DownPayment = Convert.ToDouble(txtDownPayment.Text);
                InterestRate = Convert.ToDouble(txtInterestRate.Text);
                LoanTerm = Convert.ToInt32(txtLoanTerm.Text);

            }


            catch
            {
                MessageBox.Show("Invalid Numeric Entry.", "Error");
                return;
            
            }

            double AmountToFinance = PurchasePrice - DownPayment;
            double MonthlyAmount = (AmountToFinance - InterestRate) / (1 - Math.Pow(1 + InterestRate, -LoanTerm));
            txtAmountFinance.Text = AmountToFinance.ToString("C");
            txtMonthlyPayment.Text = MonthlyAmount.ToString("C");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

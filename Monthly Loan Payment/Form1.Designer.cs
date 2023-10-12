namespace Monthly_Loan_Payment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAmountFinance = new System.Windows.Forms.Label();
            this.lblMonthlyPay = new System.Windows.Forms.Label();
            this.txtAmountFinance = new System.Windows.Forms.TextBox();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Down Payment ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interest Rate (annual)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loan Term(Months)";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(239, 92);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(259, 26);
            this.txtPurchasePrice.TabIndex = 4;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(239, 139);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(259, 26);
            this.txtDownPayment.TabIndex = 5;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(239, 188);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(259, 26);
            this.txtInterestRate.TabIndex = 6;
            // 
            // txtLoanTerm
            // 
            this.txtLoanTerm.Location = new System.Drawing.Point(239, 250);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(259, 26);
            this.txtLoanTerm.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(44, 319);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 39);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAmountFinance
            // 
            this.lblAmountFinance.AutoSize = true;
            this.lblAmountFinance.Location = new System.Drawing.Point(539, 106);
            this.lblAmountFinance.Name = "lblAmountFinance";
            this.lblAmountFinance.Size = new System.Drawing.Size(144, 20);
            this.lblAmountFinance.TabIndex = 9;
            this.lblAmountFinance.Text = "Amount to Finance";
            // 
            // lblMonthlyPay
            // 
            this.lblMonthlyPay.AutoSize = true;
            this.lblMonthlyPay.Location = new System.Drawing.Point(530, 194);
            this.lblMonthlyPay.Name = "lblMonthlyPay";
            this.lblMonthlyPay.Size = new System.Drawing.Size(130, 20);
            this.lblMonthlyPay.TabIndex = 10;
            this.lblMonthlyPay.Text = "Monthly Payment";
            // 
            // txtAmountFinance
            // 
            this.txtAmountFinance.Location = new System.Drawing.Point(689, 100);
            this.txtAmountFinance.Name = "txtAmountFinance";
            this.txtAmountFinance.Size = new System.Drawing.Size(100, 26);
            this.txtAmountFinance.TabIndex = 11;
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.Location = new System.Drawing.Point(688, 185);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.Size = new System.Drawing.Size(100, 26);
            this.txtMonthlyPayment.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(626, 334);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 45);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtMonthlyPayment);
            this.Controls.Add(this.txtAmountFinance);
            this.Controls.Add(this.lblMonthlyPay);
            this.Controls.Add(this.lblAmountFinance);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLoanTerm);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Monthly Loan Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAmountFinance;
        private System.Windows.Forms.Label lblMonthlyPay;
        private System.Windows.Forms.TextBox txtAmountFinance;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.Button btnClose;
    }
}


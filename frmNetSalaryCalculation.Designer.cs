namespace ModelViewPresenterSample
{
    partial class frmNetSalaryCalculation
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
            this.btnCalculateNetSalary = new System.Windows.Forms.Button();
            this.nudGrossSalary = new System.Windows.Forms.NumericUpDown();
            this.nudDiscounts = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNetSalary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrossSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscounts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculateNetSalary
            // 
            this.btnCalculateNetSalary.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalculateNetSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateNetSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateNetSalary.ForeColor = System.Drawing.Color.White;
            this.btnCalculateNetSalary.Location = new System.Drawing.Point(227, 244);
            this.btnCalculateNetSalary.Name = "btnCalculateNetSalary";
            this.btnCalculateNetSalary.Size = new System.Drawing.Size(190, 81);
            this.btnCalculateNetSalary.TabIndex = 0;
            this.btnCalculateNetSalary.Text = "Calculate Net Salary";
            this.btnCalculateNetSalary.UseVisualStyleBackColor = false;
            this.btnCalculateNetSalary.Click += new System.EventHandler(this.BtnCalculateNetSalary_Click);
            // 
            // nudGrossSalary
            // 
            this.nudGrossSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGrossSalary.Location = new System.Drawing.Point(227, 54);
            this.nudGrossSalary.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudGrossSalary.Name = "nudGrossSalary";
            this.nudGrossSalary.Size = new System.Drawing.Size(120, 34);
            this.nudGrossSalary.TabIndex = 1;
            this.nudGrossSalary.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nudDiscounts
            // 
            this.nudDiscounts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiscounts.Location = new System.Drawing.Point(227, 112);
            this.nudDiscounts.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudDiscounts.Name = "nudDiscounts";
            this.nudDiscounts.Size = new System.Drawing.Size(120, 34);
            this.nudDiscounts.TabIndex = 2;
            this.nudDiscounts.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gross salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Discounts";
            // 
            // lblNetSalary
            // 
            this.lblNetSalary.AutoSize = true;
            this.lblNetSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetSalary.Location = new System.Drawing.Point(222, 173);
            this.lblNetSalary.Name = "lblNetSalary";
            this.lblNetSalary.Size = new System.Drawing.Size(20, 28);
            this.lblNetSalary.TabIndex = 5;
            this.lblNetSalary.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Net Salary";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 380);
            this.panel1.TabIndex = 7;
            // 
            // frmNetSalaryCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNetSalary);
            this.Controls.Add(this.nudDiscounts);
            this.Controls.Add(this.nudGrossSalary);
            this.Controls.Add(this.btnCalculateNetSalary);
            this.MaximizeBox = false;
            this.Name = "frmNetSalaryCalculation";
            this.Text = "Model View Presenter sample";
            ((System.ComponentModel.ISupportInitialize)(this.nudGrossSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateNetSalary;
        private System.Windows.Forms.NumericUpDown nudGrossSalary;
        private System.Windows.Forms.NumericUpDown nudDiscounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNetSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}
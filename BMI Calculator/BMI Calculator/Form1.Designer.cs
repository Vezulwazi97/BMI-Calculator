namespace BMI_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbBMI = new GroupBox();
            lblOutput = new Label();
            btnCalculate = new Button();
            lstOutput = new ListBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            lblHeight = new Label();
            lblWeight = new Label();
            btnClear = new Button();
            gbBMI.SuspendLayout();
            SuspendLayout();
            // 
            // gbBMI
            // 
            gbBMI.Controls.Add(btnClear);
            gbBMI.Controls.Add(lblOutput);
            gbBMI.Controls.Add(btnCalculate);
            gbBMI.Controls.Add(lstOutput);
            gbBMI.Controls.Add(txtHeight);
            gbBMI.Controls.Add(txtWeight);
            gbBMI.Controls.Add(lblHeight);
            gbBMI.Controls.Add(lblWeight);
            gbBMI.Location = new Point(266, 66);
            gbBMI.Name = "gbBMI";
            gbBMI.Size = new Size(419, 474);
            gbBMI.TabIndex = 0;
            gbBMI.TabStop = false;
            gbBMI.Text = "Determine your BMI";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(193, 409);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 38);
            lblOutput.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(65, 218);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(121, 29);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lstOutput
            // 
            lstOutput.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 45;
            lstOutput.Location = new Point(151, 286);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(149, 94);
            lstOutput.TabIndex = 4;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(273, 123);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(273, 66);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 27);
            txtWeight.TabIndex = 2;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(34, 123);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(152, 20);
            lblHeight.TabIndex = 1;
            lblHeight.Text = "Enter your height (m):";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(34, 65);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(158, 20);
            lblWeight.TabIndex = 0;
            lblWeight.Text = "Enter your weight (kg):";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(246, 218);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 568);
            Controls.Add(gbBMI);
            Name = "Form1";
            Text = "Form1";
            gbBMI.ResumeLayout(false);
            gbBMI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbBMI;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label lblHeight;
        private Label lblWeight;
        private Button btnCalculate;
        private ListBox lstOutput;
        private Label lblOutput;
        private Button btnClear;
    }
}

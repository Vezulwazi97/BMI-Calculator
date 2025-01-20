namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double height, weight, bmi;

            if (double.TryParse(txtHeight.Text, out height))
                if (double.TryParse(txtWeight.Text, out weight))
                {
                    bmi = weight / (height * height); // Use comma instead of period when entering height and weight
                    lstOutput.Items.Add(Math.Round(bmi, 1));

                    if (bmi <= 18.5)
                    {
                        lblOutput.Text = "Underweight";
                    }
                    else if (bmi <= 24.9)
                    {
                        lblOutput.Text = "Healthy Weight";
                    }
                    else if (bmi <= 29.9)
                    {
                        lblOutput.Text = "Overweight";
                    }
                    else
                    {
                        lblOutput.Text = "Obese";
                    }
                }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHeight.Clear();
            txtWeight.Clear();
            lstOutput.Items.Clear();
            lblOutput.Text = "";
        }
    }
}

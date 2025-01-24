using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private double resultValue = 0; 
        private string operationPerformed = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e) => NumberButton_Click("1");
        private void btn2_Click(object sender, EventArgs e) => NumberButton_Click("2");
        private void btn3_Click(object sender, EventArgs e) => NumberButton_Click("3");
        private void btn4_Click(object sender, EventArgs e) => NumberButton_Click("4");
        private void btn5_Click(object sender, EventArgs e) => NumberButton_Click("5");
        private void btn6_Click(object sender, EventArgs e) => NumberButton_Click("6");
        private void btn7_Click(object sender, EventArgs e) => NumberButton_Click("7");
        private void btn8_Click(object sender, EventArgs e) => NumberButton_Click("8");
        private void btn9_Click(object sender, EventArgs e) => NumberButton_Click("9");
        private void btn0_Click(object sender, EventArgs e) => NumberButton_Click("0");

        private void NumberButton_Click(string number)
        {
            if (txtTotal.Text == "0" || isOperationPerformed)
                txtTotal.Clear();

            isOperationPerformed = false;
            txtTotal.Text += number;
        }

        private void btnplus_Click(object sender, EventArgs e) => OperationButton_Click("+");
        private void btnmin_Click(object sender, EventArgs e) => OperationButton_Click("-");
        private void btnmul_Click(object sender, EventArgs e) => OperationButton_Click("*");
        private void btndiv_Click(object sender, EventArgs e) => OperationButton_Click("/");

        private void OperationButton_Click(string operation)
        {
            if (!isOperationPerformed)
            {
                resultValue = double.Parse(txtTotal.Text);
                operationPerformed = operation;
                isOperationPerformed = true;
            }
        }

        private void btneql_Click(object sender, EventArgs e)
        {
            double newValue = double.Parse(txtTotal.Text);

            switch (operationPerformed)
            {
                case "+":
                    txtTotal.Text = (resultValue + newValue).ToString();
                    break;
                case "-":
                    txtTotal.Text = (resultValue - newValue).ToString();
                    break;
                case "*":
                    txtTotal.Text = (resultValue * newValue).ToString();
                    break;
                case "/":
                    if (newValue != 0)
                        txtTotal.Text = (resultValue / newValue).ToString();
                    else
                        MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }

            resultValue = 0;
            operationPerformed = "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "0";
            resultValue = 0;
            operationPerformed = "";
            isOperationPerformed = false;
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtTotal.Text);
            txtTotal.Text = Math.Sqrt(value).ToString();
        }

        private void btnsquare_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtTotal.Text);
            txtTotal.Text = Math.Pow(value, 2).ToString();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtTotal.Text);
            txtTotal.Text = Math.Log10(value).ToString();
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtTotal.Text);
            txtTotal.Text = Math.Sin(value * (Math.PI / 180)).ToString(); // Convert to radians
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtTotal.Text);
            txtTotal.Text = Math.Cos(value * (Math.PI / 180)).ToString();
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtTotal.Text);
            txtTotal.Text = Math.Tan(value * (Math.PI / 180)).ToString();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            // Optional validation logic
        }
    }
}

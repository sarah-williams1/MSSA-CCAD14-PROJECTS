namespace Assignment_4._1._2
{
    public partial class CalculatorForm : Form, ICalculator
    {
        double firstNumber = 0;
        string operation = "";
        public CalculatorForm()
        {
            InitializeComponent();
        }

        public void MethodAdd()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            operation = "+";

        }
        public void MethodSubtract()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            operation = "-";
        }

        public void MethodMultiply()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            operation = "*";
        }

        public void MethodDivide()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            operation = "/";
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "1";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "1"; // Concatinates 1 to the Result text box
            }
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "2";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "2";
            }
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "3";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "3";
            }
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "4";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "4";
            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "5";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "5";
            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "6";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "6";
            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "7";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "7";
            }
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "8";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "8";
            }
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "9";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "9";
            }
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "0";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "0";
            }
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "0.";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + ".";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "0";
            }
            else
            {
                ResultTextBox.Text = "0";
            }
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            MethodAdd();
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            MethodSubtract();
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            MethodMultiply();
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            MethodDivide();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(ResultTextBox.Text);
            double result;
            
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    ResultTextBox.Text = Convert.ToString(result);
                    firstNumber = result;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    ResultTextBox.Text = Convert.ToString(result);
                    firstNumber = result;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    ResultTextBox.Text = Convert.ToString(result);
                    firstNumber = result;
                    break;
                case "/":
                    if (secondNumber > 0)
                    {
                        result = firstNumber / secondNumber;
                        ResultTextBox.Text = Convert.ToString(result);
                        firstNumber = result;
                    }
                    else
                    {
                        ResultTextBox.Text = "Divide By Zero Error";
                    }
                break;                                    
            }
        }
    }
}

namespace пр14
{
    public partial class Form1 : Form
    {
        private double firstNumber;
        private string operation = string.Empty;
        private bool isOperationSelected;
        private bool isResultShown;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            string buttonText = button.Text;

            if (isOperationSelected || isResultShown || !IsDisplayNumber())
            {
                lblDisplay.Text = "0";
                isOperationSelected = false;
                isResultShown = false;
            }

            if (buttonText == ".")
            {
                if (!lblDisplay.Text.Contains('.'))
                {
                    lblDisplay.Text += ".";
                }

                return;
            }

            lblDisplay.Text = lblDisplay.Text == "0"
                ? buttonText
                : lblDisplay.Text + buttonText;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            SelectOperation("+");
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            SelectOperation("-");
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            SelectOperation("*");
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            SelectOperation("/");
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operation) || !TryGetDisplayNumber(out double secondNumber))
            {
                return;
            }

            double result;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        lblDisplay.Text = "Помилка: ділення на нуль";
                        operation = string.Empty;
                        isOperationSelected = false;
                        isResultShown = true;
                        return;
                    }

                    result = firstNumber / secondNumber;
                    break;
                default:
                    return;
            }

            lblDisplay.Text = FormatNumber(result);
            firstNumber = result;
            operation = string.Empty;
            isOperationSelected = false;
            isResultShown = true;
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            ResetCalculator();
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (isOperationSelected || isResultShown || !IsDisplayNumber())
            {
                ResetCalculator();
                return;
            }

            lblDisplay.Text = lblDisplay.Text.Length > 1
                ? lblDisplay.Text[..^1]
                : "0";
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            if (!TryGetDisplayNumber(out double number))
            {
                ResetCalculator();
                return;
            }

            lblDisplay.Text = FormatNumber(number / 100);
        }

        private void SelectOperation(string selectedOperation)
        {
            if (!TryGetDisplayNumber(out firstNumber))
            {
                ResetCalculator();
                return;
            }

            operation = selectedOperation;
            isOperationSelected = true;
            isResultShown = false;
        }

        private bool TryGetDisplayNumber(out double number)
        {
            return double.TryParse(
                lblDisplay.Text,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out number);
        }

        private bool IsDisplayNumber()
        {
            return TryGetDisplayNumber(out _);
        }

        private static string FormatNumber(double number)
        {
            return number.ToString("G15", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void ResetCalculator()
        {
            firstNumber = 0;
            operation = string.Empty;
            isOperationSelected = false;
            isResultShown = false;
            lblDisplay.Text = "0";
        }
    }
}

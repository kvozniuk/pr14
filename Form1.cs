namespace пр14
{
    public partial class Form1 : Form
    {
        private double firstNumber;
        private string operation = string.Empty;
        private bool isCalculatorOn = true;
        private bool isOperationSelected;
        private bool isResultShown;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += Form1_KeyDown;
            ApplyCalculatorPowerState();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                AddDisplayCharacter(button.Text);
            }
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (!isCalculatorOn)
            {
                return;
            }

            string? digit = GetDigitFromKey(e.KeyCode);

            if (digit is null)
            {
                return;
            }

            AddDisplayCharacter(digit);
            MarkKeyAsHandled(e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!isCalculatorOn)
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }

            switch (keyData & Keys.KeyCode)
            {
                case Keys.Left:
                    MoveButtonFocus(0, -1);
                    return true;
                case Keys.Right:
                    MoveButtonFocus(0, 1);
                    return true;
                case Keys.Up:
                    MoveButtonFocus(-1, 0);
                    return true;
                case Keys.Down:
                    MoveButtonFocus(1, 0);
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void AddDisplayCharacter(string buttonText)
        {
            if (!isCalculatorOn)
            {
                return;
            }

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
            using ConfirmClearForm confirm = new();

            if (confirm.ShowDialog(this) == DialogResult.Yes)
            {
                ResetCalculator();
            }
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

        private void RadioPower_CheckedChanged(object sender, EventArgs e)
        {
            ApplyCalculatorPowerState();
        }

        private void LblDisplay_TextChanged(object sender, EventArgs e)
        {
            string displayText = lblDisplay.Text;

            if (string.IsNullOrEmpty(displayText) || IsDisplayNumber())
            {
                lblDisplay.ForeColor = CountDigits(displayText) >= 7
                    ? Color.DarkGreen
                    : Color.Black;
            }
            else
            {
                lblDisplay.ForeColor = Color.DarkRed;
            }
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

        private void MoveButtonFocus(int rowDelta, int columnDelta)
        {
            Button[,] buttonGrid =
            {
                { btnCE, btnBackspace, btnPercent, btnDivide },
                { btn7, btn8, btn9, btnMultiply },
                { btn4, btn5, btn6, btnMinus },
                { btn1, btn2, btn3, btnPlus },
                { btn0, btnDecimal, btnEquals, btnEquals }
            };

            Button? activeButton = ActiveControl as Button;

            for (int row = 0; row < buttonGrid.GetLength(0); row++)
            {
                for (int column = 0; column < buttonGrid.GetLength(1); column++)
                {
                    if (buttonGrid[row, column] != activeButton)
                    {
                        continue;
                    }

                    int nextRow = Math.Clamp(row + rowDelta, 0, buttonGrid.GetLength(0) - 1);
                    int nextColumn = Math.Clamp(column + columnDelta, 0, buttonGrid.GetLength(1) - 1);
                    buttonGrid[nextRow, nextColumn].Focus();
                    return;
                }
            }

            btnCE.Focus();
        }

        private void ApplyCalculatorPowerState()
        {
            isCalculatorOn = radioOn.Checked;
            SetCalculatorButtonsEnabled(isCalculatorOn);
            KeyPreview = isCalculatorOn;

            if (isCalculatorOn)
            {
                if (string.IsNullOrEmpty(lblDisplay.Text))
                {
                    lblDisplay.Text = "0";
                }

                return;
            }

            firstNumber = 0;
            operation = string.Empty;
            isOperationSelected = false;
            isResultShown = false;
            lblDisplay.Text = string.Empty;
            radioOff.Focus();
        }

        private void SetCalculatorButtonsEnabled(bool isEnabled)
        {
            foreach (Control control in tlpButtonsPanel.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = isEnabled;
                }
            }
        }

        private static void MarkKeyAsHandled(KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private static string? GetDigitFromKey(Keys keyCode)
        {
            if (keyCode >= Keys.D0 && keyCode <= Keys.D9)
            {
                return ((int)keyCode - (int)Keys.D0).ToString(System.Globalization.CultureInfo.InvariantCulture);
            }

            if (keyCode >= Keys.NumPad0 && keyCode <= Keys.NumPad9)
            {
                return ((int)keyCode - (int)Keys.NumPad0).ToString(System.Globalization.CultureInfo.InvariantCulture);
            }

            return null;
        }

        private static int CountDigits(string text)
        {
            int count = 0;

            foreach (char symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }

            return count;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class CalculatorForm : Form
    {
        float initialDisplayFontSize;
        private CalculatorEngine calcEngine;
        long previousOperand;
        string pendingOperator;


        public CalculatorForm()
        {
            InitializeComponent();
            initialDisplayFontSize = display.Font.Size;
            calcEngine = new CalculatorEngine();
        }

        private void operator_button_Click(object sender, EventArgs e)
        {
            Button buttonClick = (Button)sender;
            string raw = display.Text.Replace("\u00A0", "");

            if (long.TryParse(raw, out long result))
            {
                if(!string.IsNullOrEmpty(pendingOperator))
                {
                    try
                    {
                        checked
                        {
                            result = calculate(previousOperand, result, pendingOperator);
                        }
                    }
                    catch (OverflowException)
                    {
                        display.Text = "0";
                        expression_bar.Text = "";
                        pendingOperator = "";
                        previousOperand = 0;
                        resetDisplayTextSize();
                        MessageBox.Show("Result is too large to be displayed");
                        return;
                    }
                }
                previousOperand = result;
                pendingOperator = buttonClick.Text;
                expression_bar.Text = result.ToString("N0", new CultureInfo("sv-SE")) + " " + pendingOperator;
                display.Text = "0";
                resetDisplayTextSize();
            }
        }

        private long calculate(long operand1, long operand2, string operatorSymbol)
        {
            long total = 0;

            if (operatorSymbol == btn_plus.Text)
            {
                operatorSymbol = "+";
            }

            if (operatorSymbol == btn_minus.Text)
            {
                operatorSymbol = "-";
            }

            if (operatorSymbol == btn_multiply.Text)
            {
                operatorSymbol = "×";
            }

            if (operatorSymbol == btn_divide.Text)
            {
                operatorSymbol = "÷";
            }

            switch (operatorSymbol)
            {
                case "+":
                    total = operand1 + operand2;
                    break;
                case "-":
                    total = operand1 - operand2;
                    break;
                case "×":
                    total = operand1 * operand2;
                    break;
                case "÷":
                    if (operand2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    total = operand1 / operand2;
                    break;
            }
            return total;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            string raw = display.Text.Replace("\u00A0", "");

            if(string.IsNullOrEmpty(pendingOperator))
            {
                return;
            }

            try
            {
                checked
                {
                    if (long.TryParse(raw, out long currentOperand))
                    {
                        long total = 0;

                        if (pendingOperator == btn_plus.Text)
                        {
                            pendingOperator = "+";
                        }

                        if (pendingOperator == btn_minus.Text)
                        {
                            pendingOperator = "-";
                        }

                        if (pendingOperator == btn_multiply.Text)
                        {
                            pendingOperator = "×";
                        }

                        if (pendingOperator == btn_divide.Text)
                        {
                            pendingOperator = "÷";
                        }


                        switch (pendingOperator)
                        {
                            case "+":
                                total = previousOperand + currentOperand;
                                break;
                            case "-":
                                total = previousOperand - currentOperand;
                                break;
                            case "×":
                                total = previousOperand * currentOperand;
                                break;
                            case "÷":
                                if (currentOperand == 0)
                                {
                                    display.Text = "0";
                                    expression_bar.Text = "";
                                    pendingOperator = "";
                                    MessageBox.Show("Cannot divide by 0");
                                    return;
                                }
                                total = previousOperand / currentOperand;
                                break;
                        }

                        expression_bar.Text = "";
                        pendingOperator = "";
                        previousOperand = 0; currentOperand = 0;
                        display.Text = total.ToString("N0", new CultureInfo("sv-SE"));
                        adjustDisplayTextSize();
                    }
                }
            }
            catch (OverflowException)
            {
                display.Text = "0";
                expression_bar.Text = "";
                pendingOperator = "";
                previousOperand = 0;
                resetDisplayTextSize();
                MessageBox.Show("Result is too large to be displayed"); 
                return;
            }

            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            previousOperand = 0;
            pendingOperator = "";
            display.Text = "0";
            resetDisplayTextSize();
            expression_bar.Text = "";
        }

        private void digit_button_Click(object sender, EventArgs e)
        {
            Button buttonClick = (Button)sender;
            if(display.Text == "0")
            {
                display.Text = buttonClick.Text;
            }
            else
            {

                string raw = display.Text.Replace("\u00A0", "") + buttonClick.Text;

                if (raw.Count() > 16)
                {
                    return;
                }

                if (long.TryParse(raw, out long result))
                {
                    display.Text = result.ToString("N0", new CultureInfo("sv-SE"));
                    adjustDisplayTextSize();
                }
                else
                {
                    MessageBox.Show(raw);
                }
            }
        }

        private void adjustDisplayTextSize()
        {
            float fontSize = initialDisplayFontSize;

            while(TextRenderer.MeasureText(display.Text, display.Font).Width > display.Width)
            {
                fontSize -= 1;
                display.Font = new Font(display.Font.FontFamily, fontSize);
            }

        }

        private void resetDisplayTextSize()
        {
            display.Font = new Font(display.Font.FontFamily, initialDisplayFontSize);
        }
    }
}

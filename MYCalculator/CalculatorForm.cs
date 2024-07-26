using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYCalculator
{
    public partial class CalculatorForm : Form
    {
        string currentNumber = null;
        string equation = null;
        string result = null;

        public bool checkCurrentNumber()
        {
            if( currentNumber == null)
            {
                return false;
            }
            if(currentNumber.Length == 0)
            {
                return false;
            }
            return true;
        }

        public string doEquation(string eq)
        {
            if (equation != null)
            {
                string Lastoperator = getLastOpeartor(eq);

                eq = eq.Remove(eq.Length - 1);
                result = getEquation(eq) + Lastoperator;
                return result;
            }
            return eq;
        }

        public string getEquation(string eq)
        {
            char[] operators = { '+', '-', 'x', '/' };
            int operatorIndex = -1;
            char operation = '\0';
            float number1 , number2 ;

            foreach (char op in operators)
            {
                operatorIndex = eq.IndexOf(op);
                if (operatorIndex != -1)
                {
                    operation = op;
                    break;
                }
            }

            if (operatorIndex == -1)
            {
                
            }

            string leftPart = eq.Substring(0, operatorIndex);
            string rightPart = eq.Substring(operatorIndex + 1);

            if (!double.TryParse(leftPart, out double leftNumber) || !double.TryParse(rightPart, out double rightNumber))
            {
                throw new ArgumentException("Sayılar geçerli değil.");
            }


            double results = operation switch
            {
                '+' => leftNumber + rightNumber,
                '-' => leftNumber - rightNumber,
                'x' => leftNumber * rightNumber,
                '/' => leftNumber / rightNumber,
                _ => throw new ArgumentException("Geçersiz işlem.")
            };


            return results.ToString();
        }

        public string getLastOpeartor(string eq)
        {
            if (string.IsNullOrEmpty(eq))
            {
                throw new ArgumentException("String boş olamaz.");
            }

            return eq[eq.Length - 1].ToString();
        }

        public void AddOperation(string type)
        {
            if (checkCurrentNumber())
            {
                string fake_eq = equation + currentNumber + type;
                currentNumber = null;
                labelNumber.Text = "0";
                equation = doEquation(fake_eq);
                labelEquation.Text = equation;
            }
        }

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            currentNumber = currentNumber + "/100" ;
            currentNumber = getEquation(currentNumber);
            labelNumber.Text = currentNumber;
        }

        private void buttonDeleteNumber_Click(object sender, EventArgs e)
        {
            currentNumber = null;
            labelNumber.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            currentNumber = null;
            equation = null;
            labelEquation = null;
            labelNumber.Text = "0";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            currentNumber = RemoveLastChar(currentNumber);
            labelNumber.Text = currentNumber;
        }

        static string RemoveLastChar(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length <= 1)
            {
                return string.Empty;
            }

            return input.Substring(0, input.Length - 1);
        }

        private void buttonInverse_Click(object sender, EventArgs e)
        {
            currentNumber = "1/" + currentNumber;
            currentNumber = getEquation(currentNumber);
            labelNumber.Text = currentNumber;
        }

        private void buttonsquared_Click(object sender, EventArgs e)
        {
            equation = currentNumber + "x" + currentNumber;
            currentNumber = getEquation(equation);

            labelNumber.Text = currentNumber;
            labelEquation.Text = null ;
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            double.TryParse(currentNumber, out double number);
            number = Math.Sqrt(number);
            currentNumber = number.ToString();
            labelNumber.Text = currentNumber;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            AddOperation("/");
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            AddOperation("x");
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            AddOperation("-");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            AddOperation("+");
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            if (currentNumber[0] != '-')
            {
                currentNumber = "-" + currentNumber;
            }
            else
            {
                string d = currentNumber.Substring(1);
                currentNumber = d;
            }
            labelNumber.Text = currentNumber;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if(checkCurrentNumber())
            {
                currentNumber = currentNumber + ".";
                labelNumber.Text = currentNumber;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (currentNumber == null)
            {
                currentNumber = equation.Substring(0, equation.Length - 1);
            }
            else
            {
                string a = equation + currentNumber;
                a = getEquation(a);
                currentNumber = a;
            }
            equation = null;
            labelNumber.Text = currentNumber;
            labelEquation.Text = null;
        }

        //Numbers
        private void buttonZero_Click(object sender, EventArgs e)
        {
            currentNumber = currentNumber + "0";
            labelNumber.Text = currentNumber;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            currentNumber = currentNumber + "1";
            labelNumber.Text = currentNumber;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            currentNumber = currentNumber + "2";
            labelNumber.Text = currentNumber;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            currentNumber = currentNumber + "3";
            labelNumber.Text = currentNumber;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            currentNumber = currentNumber + "4";
            labelNumber.Text = currentNumber;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            currentNumber = currentNumber + "5";
            labelNumber.Text = currentNumber;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            currentNumber = currentNumber + "6";
            labelNumber.Text = currentNumber;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            currentNumber = currentNumber + "7";
            labelNumber.Text = currentNumber;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            currentNumber = currentNumber + "8";
            labelNumber.Text = currentNumber;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            currentNumber = currentNumber + "9";
            labelNumber.Text = currentNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        double firstValue=0;
        double secondValue;
        bool isNewEntry = true;
        bool isSecondValue = false;
        string firstOperation = "asdfgh";
        int count = 0;
        double result;
        public Form1()
        {
            InitializeComponent();
            tbox.Text = firstValue.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculator";           
        }
        //entry events
        private void btn_entry_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string value = btn.Text;
            if (Int32.TryParse(value, out int num))
            {
                if (isNewEntry || tbox.Text.Equals("0"))
                {
                    tbox.Text = "";
                }
                isNewEntry = false;
                tbox.Text += value;
                if (isSecondValue)
                {
                    secondValue = Double.Parse(tbox.Text);
                }
                else
                {
                    firstValue = Double.Parse(tbox.Text);
                }
            }
            if (value.Equals("."))
            {
                if (isNewEntry)
                {
                    return;
                }
                if (!tbox.Text.Contains("."))
                {
                    isNewEntry = false;
                    tbox.Text += value;
                    if (isSecondValue)
                    {
                        secondValue = Double.Parse(tbox.Text);
                    }
                    else
                    {
                        firstValue = Double.Parse(tbox.Text);
                    }
                }
                return;
            }
        }
        //4 operations =>>>> add, subtract, multiply, divide
        public double operationAdd()
        {
            if (count == 1)
            {
                result = firstValue + secondValue;
            }
            else
            {
                result = result + secondValue;
            }
            return result;
        }
        public double operationSubtract()
        {
            if (count == 1)
            {
                result = firstValue - secondValue;
            }
            else
            {
                result = result - secondValue;
            }
            return result;
        }
        public double operationMultiply()
        {
            if (count == 1)
            {
                result = firstValue * secondValue;
            }
            else
            {
                result = result * secondValue;
            }
            return result;
        }
        public double operationDivide()
        {
            if (count == 1)
            {
                return result = firstValue / secondValue;
            }
            else
            {
                result = result / secondValue;
            }
            return result;       
        }
        //6 events =>>>> add, multiply, divide, subtract, equal, clear
        private void btn_add_Click(object sender, EventArgs e)
        {
            count++;
            firstOperation = "add";
            tbox.Text = "0";
            isSecondValue = true;
        }
        private void btn_multiply_Click(object sender, EventArgs e)
        {
            count++;
            firstOperation = "multiply";
            tbox.Text = "0";
            isSecondValue = true;
        }
        private void btn_divide_Click(object sender, EventArgs e)
        {
            count++;
            firstOperation = "divide";
            tbox.Text = "0";
            isSecondValue = true;
        }
        private void btn_subtract_Cick(object sender, EventArgs e)
        {
            count++;
            firstOperation = "subtract";
            tbox.Text = "0";
            isSecondValue = true;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbox.Text = "0";
            firstValue = 0;
            secondValue = 0;
            isSecondValue = false;
        }
        private void btn_equal_Click(object sender, EventArgs e)
        {
            switch (firstOperation)
            {
                case "add": tbox.Text = operationAdd().ToString();
                    break;
                case "subtract": tbox.Text = operationSubtract().ToString();
                    break;
                case "multiply": tbox.Text = operationMultiply().ToString();
                    break;
                case "divide": tbox.Text = operationDivide().ToString();
                    break;
            }
        }
    }
}


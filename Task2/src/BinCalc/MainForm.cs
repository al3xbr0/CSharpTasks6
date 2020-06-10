using System;
using System.Linq;
using System.Windows.Forms;

namespace BinCalc
{
    public partial class MainForm : Form
    {
        private int openParenthesisCount;
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddSym(char sym)
        {
            string text = input.Text;
            if (!char.IsDigit(sym) && !char.IsPunctuation(sym)
                && !char.IsDigit(text.Last()) && !char.IsPunctuation(text.Last()))
            {
                input.Text = text.Remove(text.Length - 1) + sym;
                return;
            }
            if (text != "0" || !char.IsDigit(sym) && sym != '(')
            {
                if (sym == '(')
                {
                    openParenthesisCount++;
                }
                else if (sym == ')')
                {
                    if (openParenthesisCount > 0)
                    {
                        openParenthesisCount--;
                    }
                    else { return; }
                }
                input.Text += sym;
                return;
            }
            input.Text = sym.ToString();
        }

        private void BackSpace()
        {
            string text = input.Text;
            if (text == "0" || text.Length == 1)
            {
                input.Text = "0";
                return;
            }
            input.Text = text.Substring(0, text.Length - 1);
        }
        private void Clear()
        {
            input.Text = "0";
        }

        private void Calculate()
        {
            string text = input.Text;
            if (text.Length <= 2 || !(char.IsDigit(text.Last()) || text.Last() == ')'))
            {
                return;
            }
            text = text.Replace('−', '-').Replace('×', '*').Replace('÷', '/');

            Calculator calc = new Calculator(text);
            try
            {
                string res = calc.Result();
                input.Text = res;
                input.Focus();
                input.SelectionStart = input.Text.Length;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Zero division!", "Input is wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                input.Text = "0";
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Name)
            {
                case "button0":
                case "button1":
                case "buttonPlus":
                case "buttonMinus":
                case "buttonMult":
                case "buttonDiv":
                case "buttonLeftP":
                case "buttonRightP":
                    AddSym(b.Text[0]);
                    break;
                case "buttonRes":
                    Calculate();
                    break;
                case "buttonC":
                    Clear();
                    break;
                case "buttonDel":
                    BackSpace();
                    break;
            }
        }

        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    button0.PerformClick();
                    break;
                case '1':
                    button1.PerformClick();
                    break;
                case '+':
                    buttonPlus.PerformClick();
                    break;
                case '-':
                    buttonMinus.PerformClick();
                    break;
                case '*':
                    buttonMult.PerformClick();
                    break;
                case '/':
                    buttonDiv.PerformClick();
                    break;
                case '(':
                    buttonLeftP.PerformClick();
                    break;
                case ')':
                    buttonRightP.PerformClick();
                    break;
                case (char)Keys.Enter:
                    buttonRes.PerformClick();
                    break;
                case (char)Keys.Delete:
                    buttonC.PerformClick();
                    break;
                case (char)Keys.Back:
                    buttonDel.PerformClick();
                    break;
            }
        }

        private void Key_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                buttonC.PerformClick();
            }
        }
    }
}
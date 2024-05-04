using System;
using System.Windows.Forms;

namespace typograph
{
    public partial class Typographh : Form
    {
        public Typographh()
        {
            InitializeComponent();
        }

        public void typograph_Click(object sender, EventArgs e)
        {
            textBox.ReadOnly = false;
            textBox.Text = ruleWhitespace(textBox.Text);
            textBox.Text = ruleDushnila(textBox.Text);
            textBox.Text = rulePlusMinus(textBox.Text);
            textBox.Text = ruleSharp(textBox.Text);
            textBox.Text = ruleQuotationMarks(textBox.Text);
            textBox.Text = ruleDimensions(textBox.Text);
            textBox.Text = ruleSobaka(textBox.Text);
        }
        public string ruleWhitespace(string s)
        {
            string a = "  ";
            while (s.Contains(a))
            {
                s = s.Replace("  ", " ");
            }
            return s;
        }
        public string rulePlusMinus(string s)
        {
            s = s.Replace("+-", "±");
            return s;
        }
        public string ruleSharp(string s)
        {
            s = s.Replace("шарп", "#");
            return s;
        }
        public string ruleQuotationMarks(string s)
        {
            s = s.Replace("''", "«»");
            return s;
        }
        public string ruleDimensions(string s)
        {
            s = s.Replace("x", "×");
            return s;
        }
        public string ruleDushnila(string s)
        {
            s = s.Replace(".", " фу, душнила");
            return s;
        }
        public string ruleSobaka(string s)
        {
            s = s.Replace("собака", "@");
            return s;
        }
    }
}

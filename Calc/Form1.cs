using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace calc
{
    

    public partial class Form1 : System.Windows.Forms.Form
    {
        double A, B, Res, memory;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //numbers
        private void button1_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += (sender as Button).Text; 
        }
        //pi exp 
        private void button29_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
            operation = (sender as Button).Text;
            switch (operation)
            {
                case "Pi":
                mainTextBox.Text = Convert.ToString("3,14159265358979");
                    break;
                case "Exp":
                mainTextBox.Text = Convert.ToString("2.7182818284590451");
                    break;
            }
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            mainTextBox.Clear();
        }
        // +/- dot
        private void button11_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(mainTextBox.Text);
            mainTextBox.Text = "";
            operation = (sender as Button).Text;
            switch (operation)
            {
                case "-/+":
                    mainTextBox.Text = (Convert.ToDouble(A) * -1).ToString();
                    break;
                case ",":
                    mainTextBox.Text = (Convert.ToString(A) + ",");
                    break;
            }
        }
        //sin cos tg lg10
        private void button24_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(mainTextBox.Text);
            mainTextBox.Text = "";
            operation = (sender as Button).Text;

            switch (operation)
            {
                case "Sin":
                    Res = Math.Sin((A / 180D) * Math.PI);
                    break;
                case "Cos":
                    Res = Math.Cos((A / 180D) * Math.PI);
                    break;
                case "Tg":
                    Res = Math.Tan((A / 180D) * Math.PI);
                    break;
                case "Lg":
                    Res = Math.Log10(A);
                    break;
            }
            mainTextBox.Text = Convert.ToString(Res);
        }

        private void MSaveButton_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(mainTextBox.Text);
        }

        private void MReadButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = Convert.ToString(memory);
        }

        private void MClearButton_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void MPlusButton_Click(object sender, EventArgs e)
        {
            memory += Convert.ToDouble(mainTextBox.Text);
            mainTextBox.Clear();
        }

        private void MMinusButton_Click(object sender, EventArgs e)
        {
            memory -= Convert.ToDouble(mainTextBox.Text);
            mainTextBox.Clear();
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //button memory
        



        // =
        private void button18_Click(object sender, EventArgs e)
        {
            B = Convert.ToDouble(mainTextBox.Text);
            switch (operation)
            {
                case "+":
                    Res = A + B;
                    break;
                case "-":
                    Res = A - B;
                    break;
                case "*":
                    Res = A * B;
                    break;
                case "/":
                    Res = A / B;
                    break;

            }
            mainTextBox.Text = Convert.ToString(Res);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            A = Convert.ToDouble(mainTextBox.Text);
            mainTextBox.Text = "";
            operation = (sender as Button).Text;
            
        }
    }
}

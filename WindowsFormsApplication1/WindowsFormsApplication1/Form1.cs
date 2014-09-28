using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();                      
        }

        double A;
        double Answer;
        string op;

        private void Zero_Click(object sender, EventArgs e)
        {
            Message.Text += Zero.Text;          
          
        }

        private void One_Click(object sender, EventArgs e)
        {
            Message.Text += One.Text;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Message.Text += Two.Text;

        }

        private void Three_Click(object sender, EventArgs e)
        {
            Message.Text += Three.Text;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Message.Text += Four.Text;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Message.Text += Five.Text;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Message.Text += Six.Text;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Message.Text += Seven.Text;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Message.Text += Eight.Text;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Message.Text += Nine.Text;
        }

        private void Poin_Click(object sender, EventArgs e)
        {
            Message.Text += Poin.Text;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            A = double.Parse(Message.Text);
            op = "+";
            Message.Text = "";
            
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            A = double.Parse(Message.Text);
            op = "-";
            Message.Text = "";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            A = double.Parse(Message.Text);
            op = "/";
            Message.Text = "";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            A = double.Parse(Message.Text);
            op = "/";
            Message.Text = "";

        }

        private void Equl_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+" :
                    Answer = double.Parse(Message.Text) + A;
                    Message.Text = Answer.ToString();
                    break;

                case "-" :
                    Answer = double.Parse(Message.Text) - A;
                    Message.Text = Answer.ToString();
                    break;

                case "*":
                    Answer = double.Parse(Message.Text) * A;
                    Message.Text = Answer.ToString();
                    break;

                case "/":
                    Answer = double.Parse(Message.Text) / A;
                    Message.Text = Answer.ToString();
                    break;
                case "^" :
                    Answer = Math.Pow(A, double.Parse(Message.Text)); 
                    Message.Text = Answer.ToString();
                    break;

            }


            

        }



        private void Delete_Click(object sender, EventArgs e)
        {
            Message.Text = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            A = 0;
            op = null;
            Message.Text = "";
        }

        private void Sqr_Click(object sender, EventArgs e)
        {
            A = double.Parse(Message.Text);
            Answer = Math.Sqrt(A);
            Message.Text = Answer.ToString();

        }

        private void ABS_Click(object sender, EventArgs e)
        {
            A = double.Parse(Message.Text);
            Answer = Math.Abs(A);
            Message.Text = Answer.ToString();
        }

        private void OS_Click(object sender, EventArgs e)
        {
            A = double.Parse(Message.Text);
            Answer = Math.Pow(A, 2);
            Message.Text = Answer.ToString();

        }

        private void OS_Click_1(object sender, EventArgs e)
        {
            A = double.Parse(Message.Text);
            op = "^";
            Message.Text = "";
        }

        private void e_Click(object sender, EventArgs e)
        {
            Answer = 2.71828;
            Message.Text = Answer.ToString();

        }

        private void Cos_Click(object sender, EventArgs e)
        {
            A = double.Parse(Message.Text);
            Answer = Math.Cos(A);
            Message.Text = Answer.ToString();
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            A = double.Parse(Message.Text);
            Answer = Math.Sin(A);
            Message.Text = Answer.ToString();
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            A = double.Parse(Message.Text);
            Answer = Math.Tan(A);
            Message.Text = Answer.ToString();
        }

        private void InvSin_Click(object sender, EventArgs e)
        {

            A = double.Parse(Message.Text);
            Answer = Math.Asin(A);
            Message.Text = Answer.ToString();
        }

        private void InvCos_Click(object sender, EventArgs e)
        {

            A = double.Parse(Message.Text);
            Answer = Math.Acos(A);
            Message.Text = Answer.ToString();
        }

        private void Invtan_Click(object sender, EventArgs e)
        {
            A = double.Parse(Message.Text);
            Answer = Math.Atan(A);
            Message.Text = Answer.ToString();

        }
        
         

    }
}

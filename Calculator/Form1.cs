using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            sum1 = 0;
            sum2 = 0;
        }


        double sum1 = 0;
        double sum2 = 0;
        bool op_subt = false;
        bool op_add = false;
        bool op_mul = false;
        bool op_div = false;

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label1.Text = textBox1.Text + " +";
                try
                {
                    sum1 += double.Parse(textBox1.Text);
                    textBox1.Clear();
                    op_add = true;
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {

                if (op_add)
                {
                    try
                    {
                        sum2 = sum1 + double.Parse(textBox1.Text);
                        textBox1.Text = sum2.ToString();
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                if (op_subt)
                {
                    try
                    {
                        sum2 = sum1 - double.Parse(textBox1.Text);
                        textBox1.Text = sum2.ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                if (op_mul)
                {
                    try
                    {
                        sum2 = sum1 * double.Parse(textBox1.Text);
                        textBox1.Text = sum2.ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                if (op_div)
                {


                    try
                    {
                        sum2 = sum1 / double.Parse(textBox1.Text);
                        textBox1.Text = sum2.ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }


            }

            sum1 = 0;
            sum2 = 0;
            label1.Text = "";
            op_add = false;
            op_subt = false;
            op_mul = false;
            op_div = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label1.Text = textBox1.Text + " -";
                try
                {
                    sum1 += double.Parse(textBox1.Text);
                    textBox1.Clear();
                    op_subt = true;
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label1.Text = textBox1.Text + " /";
                try
                {
                    sum1 += double.Parse(textBox1.Text);
                    textBox1.Clear();
                    op_div = true;
                }
                catch (Exception ex)
                {

                }

            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label1.Text = textBox1.Text + " *";
                try
                {
                    sum1 += double.Parse(textBox1.Text);
                    textBox1.Clear();
                    op_mul = true;
                }catch(Exception ex)
                {

                }

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                string str = textBox1.Text.Trim();
                try
                {
                    double num = double.Parse(str) * (-1);
                    textBox1.Text = num.ToString();
                }catch(Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                }


            }
        }
    }
}

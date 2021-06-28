﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikaCalculator
{
    public partial class Form1 : Form
    {
        float slag1, result, slag2;
       
        int count;
        bool znak = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    result = slag1 + float.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;
                case 2:
                    result = slag1 - float.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;
                case 3:
                    result = slag1 * float.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;
                case 4:
                    result = slag1 / float.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;

                default:
                    break;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            slag1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = slag1.ToString() + "-";
            znak = true;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            slag1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = slag1.ToString() + "*";
            znak = true;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            slag1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = slag1.ToString() + "/";
            znak = true;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            slag1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = slag1.ToString() + "+";
            znak = true;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }
        private void button19_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for(int i = 0;i < lenght; i++)
            {
                textBox1.Text += 1;
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            double tg;
            slag1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            tg = Math.Tan(slag1);
            textBox1.Text = tg.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) 
            {
                e.Handled = true;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double ctg;
            slag1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            ctg = 1/Math.Tan(slag1);
            textBox1.Text = ctg.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }
    }
}

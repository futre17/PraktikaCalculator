using System;
using System.Windows.Forms;



namespace PraktikaCalculator
{
 
    public partial class Form1 : Form
    {
        double slag1 = 0, slag2, result;
        bool dot = false, znak;
        int count;
        public Form1()
        {
            InitializeComponent();
            
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

        private void button11_Click(object sender, EventArgs e) //Точка для десятичной дроби
        {
            if (dot == false && textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text + ",";
                dot = true;
            }
        }

        private void button12_Click(object sender, EventArgs e) //Вычитание
        {
            if (textBox1.Text != "")
            {
                slag1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 2;
                label1.Text = slag1.ToString() + "-";
                znak = true;
            }
            dot = false;
        }

        private void button13_Click(object sender, EventArgs e) //Умножение
        {
            if (textBox1.Text != "")
            {
                slag1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 4;
                label1.Text = slag1.ToString() + "*";
                znak = true;
            }
            dot = false;
        }

        private void button14_Click(object sender, EventArgs e) //Деление
        {
            if (textBox1.Text != "")
            {
                slag1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 3;
                label1.Text = slag1.ToString() + "/";
                znak = true;
            }
            dot = false;
        }

        private void button15_Click(object sender, EventArgs e) //Сложение
        {
            if (textBox1.Text != "")
            {
                slag1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 1;
                label1.Text = slag1.ToString() + "+";
                znak = true;
            }
            dot = false;
        }

        private void button16_Click(object sender, EventArgs e) //Ввод знака для числа
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
            dot = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button18_Click(object sender, EventArgs e) //Стереть всё
        {
            textBox1.Text = "";
            label1.Text = "";
            textBox2.Text = "";
        }
        
        private void button19_Click(object sender, EventArgs e) //Стирание по одному
        {
             int lenght = textBox1.Text.Length - 1;
                string text = textBox1.Text;
                if (text[lenght] == ',') dot = false;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                {
                    textBox1.Text = textBox1.Text + text[i];
                }
          
            label1.Text = "";
            textBox2.Text = "";
        }

        private void button20_Click(object sender, EventArgs e) //Функция тангенса
        {
            if (textBox1.Text != "")
            {
                slag1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 5;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //Защита от ввода текста
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) 
            {
                e.Handled = true;
            }
        }

        private void button21_Click(object sender, EventArgs e) //Функция котангенса
        {
            if (textBox1.Text != "")
            {
                slag1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 6;
            }
        }

        private void button17_Click(object sender, EventArgs e) //Равно
        {
            if (textBox1.Text != "")
            {
                slag2 = Double.Parse(textBox1.Text);
               calculator2 calculator = Class1.cal2(count);
                result = calculator.Calculate(slag1, slag2);
            }
            else
            {
                calculator1 calculator = Class2.cal1(count);
                result = calculator.Calculate(slag1);
            }


            textBox2.Text = result.ToString();
            dot = false;
        }
    }
}

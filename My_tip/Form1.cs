using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_tip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void denominator1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numerator2_TextChanged(object sender, EventArgs e)
        {

        }

        private void denominator2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ch1 = numerator1.Text;
            string ch2 = denominator1.Text;
            string ch3 = numerator2.Text;
            string ch4 = denominator2.Text;

            switch (comboBox1.Text)
            {
                case "+":
                    label5.Text = "";
                    jj jjj = Drob.Summa(ch1, ch2, ch3, ch4);
                    textBox1.Text = jjj.num;
                    textBox2.Text = jjj.den;
                    break;
                case "*":
                    label5.Text = "";
                    jjj = Drob.Umnog(ch1, ch2, ch3, ch4);
                    textBox1.Text = jjj.num;
                    textBox2.Text = jjj.den;
                    break;
                case "-":
                    label5.Text = "";
                    jjj = Drob.Razn(ch1, ch2, ch3, ch4);
                    textBox1.Text = jjj.num;
                    textBox2.Text = jjj.den;
                    break;
                case "/":
                    label5.Text = "";
                    jjj = Drob.Delen(ch1, ch2, ch3, ch4);
                    textBox1.Text = jjj.num;
                    textBox2.Text = jjj.den;
                    break;
                case "Сокращение":
                    label5.Text = "";
                    
                   jjj = Drob.Sokr(ch1, ch2);
                    numerator2.Text = "";
                    numerator2.Clear();
                    denominator2.Text = "";
                    denominator2.Clear();
                    textBox1.Text = jjj.num;
                    textBox2.Text = jjj.den;
                    break;
                case "Сравнение":
                    
                    str ou = Drob.Srav(ch1, ch2, ch3, ch4);
                    label5.Text = ou.outM;

                    break;
            }
        }

        public struct jj
        {
            public string num;
            public string den;
           
            public jj(int num, int den)
            {

                this.num = num.ToString();
                this.den = den.ToString();
            }

        }
        public struct str
        {
            public string outM;
            public str(string outM)
            {
                this.outM = outM;
            }
        }



        class Drob
        {
            private int num1;
            private int denum1;
            private int num2;
            private int denum2;
            private int NUM;
            private int DENUM;

            

            public static jj Summa(string ch1, string ch2, string ch3, string ch4)
            {

                Drob drob = new Drob();

                drob.num1 = int.Parse(ch1);
                drob.denum1 = int.Parse(ch2);
                drob.num2 = int.Parse(ch3);
                drob.denum2 = int.Parse(ch4);
                int nod = 0;
                
                if (drob.denum1 == drob.denum2)
                {
                    drob.NUM = drob.num1 + drob.num2;
                    drob.DENUM = drob.denum1;

                }


                else
                {
                    drob.DENUM = drob.denum1 * drob.denum2;
                    drob.NUM = drob.num1 * drob.denum2 + drob.denum1 * drob.num2;

                }
                for (int i = 1; i <= drob.NUM; i++)
                {
                    if (drob.DENUM % i == 0 && drob.NUM % i == 0)
                    {
                        nod = i;
                    }
                }
                drob.NUM = drob.NUM / nod;
                drob.DENUM = drob.DENUM / nod;
                jj jjj = new jj(drob.NUM,drob.DENUM);

                return jjj;
        
               
                
            }
            public static jj Umnog(string ch1, string ch2, string ch3, string ch4)
            {
                Drob a = new Drob();
                a.num1 = int.Parse(ch1);
                a.denum1 = int.Parse(ch2);
                a.num2 = int.Parse(ch3);
                a.denum2 = int.Parse(ch4);
                int nod = 0;
                for (int i = 1; i <= a.num1; i++)
                {
                    if (a.denum1 % i == 0 && a.num1 % i == 0)
                    {
                        nod = i;
                    }
                }
                a.num1 = a.num1 / nod;
                a.denum1 = a.denum1 / nod;

                for (int i = 1; i <= a.num2; i++)
                {
                    if (a.denum2 % i == 0 && a.num2 % i == 0)
                    {
                        nod = i;
                    }
                }
                a.num2 = a.num2 / nod;
                a.denum2 = a.denum2 / nod;

                a.DENUM = a.denum1 * a.denum2;
                a.NUM = a.num1 * a.num2;
                jj jjj = new jj(a.NUM, a.DENUM);

                return jjj;
            }
            public static jj Delen(string ch1, string ch2, string ch3, string ch4)
            {
                Drob b = new Drob();
                b.num1 = int.Parse(ch1);
                b.denum1 = int.Parse(ch2);
                b.num2 = int.Parse(ch3);
                b.denum2 = int.Parse(ch4);
                int nod = 0;
                
                b.DENUM = b.denum1 * b.num2;
                b.NUM = b.num1 * b.denum2;
                for (int i = 1; i <= b.NUM; i++)
                {
                    if (b.DENUM % i == 0 && b.NUM % i == 0)
                    {
                        nod = i;
                    }
                }
                b.NUM = b.NUM / nod;
                b.DENUM = b.DENUM / nod;
                jj jjj = new jj(b.NUM, b.DENUM);

                return jjj;
            }
            public static jj Razn(string ch1, string ch2, string ch3, string ch4)
            {
                Drob f = new Drob();
                f.num1 = int.Parse(ch1);
                f.denum1 = int.Parse(ch2);
                f.num2 = int.Parse(ch3);
                f.denum2 = int.Parse(ch4);
                int nod = 0;
               

                f.DENUM = f.denum1 * f.denum2;
                f.NUM = f.num1 * f.denum2 - f.denum1 * f.num2;
                for (int i = 1; i <= f.NUM; i++)
                {
                    if (f.DENUM % i == 0 && f.NUM % i == 0)
                    {
                        nod = i;
                    }
                }
                if (f.NUM > 0)
                {
                    f.NUM = f.NUM / nod;
                    f.DENUM = f.DENUM / nod;
                }
                else
                {
                    f.NUM = f.NUM;
                    f.DENUM = f.DENUM;
                }
                jj jjj = new jj(f.NUM, f.DENUM);

                return jjj;
            }



            public static str Srav(string ch1, string ch2, string ch3, string ch4)
            {
                Drob d = new Drob();
                int max1;
                int max2;
                d.num1 = int.Parse(ch1);
                d.denum1 = int.Parse(ch2);
                d.num2 = int.Parse(ch3);
                d.denum2 = int.Parse(ch4);
                string outMessage = "";
                max1 = d.num1 * d.denum2;
                max2 = d.denum1 * d.num2;

                if (max1 > max2)
                {
                    outMessage = "Первая дробь больше второй";
                }
                else if (max1 == max2)
                {
                    outMessage = "Дроби равны";
                }
                else
                {
                    outMessage = "Вторая дробь больше первой";
                }

                str ou = new str(outMessage);

                return ou ;
            }
            public static jj Sokr(string ch1, string ch2)
            {
                Drob h = new Drob();
                h.num1 = int.Parse(ch1);
                h.denum1 = int.Parse(ch2);
                int nod = 0;
                for (int i = 1; i <= h.num1; i++)
                {
                    if (h.denum1 % i == 0 && h.num1 % i == 0)
                    {
                        nod = i;
                    }
                }
                h.NUM = h.num1 / nod;
                h.DENUM = h.denum1 / nod;
                jj jjj = new jj(h.NUM, h.DENUM);

                return jjj;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.ReadOnly = true;
        }

        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создать класс реализующий операции в соответствии с заданием\nПротестировать операции\nСоздать GUI приложение, а - ля калькулятор\n\n\nПравильная дробь, задаваемая числителем и знаменателем:\n-сложение\n-вычитание\n-умножение\n-деление двух дробей\n-сокращение дроби\n-сравнение двух дробей");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия сборки:\t 0.1\nАвтор:\t Тимур Рикимару");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numerator1_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 32)
            {
                e.Handled = true;
            }
        }

        private void denominator1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 32)
            {
                e.Handled = true;
            }
        }

        private void numerator2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 32)
            {
                e.Handled = true;
            }
        }

        private void denominator2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 32)
            {
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
    


}

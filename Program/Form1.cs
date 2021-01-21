using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Int64 x2, x8, x10, x16;
        public int sist, n = 1;
        public Double chi, ost;
        string y2, y8, y16;

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox11.Enabled == false)
            {
                textBox11.Enabled = true;
                comboBox4.Enabled = true;
            }
            textBox11.Text = "";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Enabled == false)
            {
                comboBox5.Enabled = true;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (button2.Enabled == false)
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "" && textBox11.Text != "")
            {
                int sist1, sist2;
                Double a1, a2;
                string operation;

                sist1 = int.Parse(comboBox2.SelectedItem.ToString());
                if (sist1 == 10)
                {
                    a1 = Double.Parse(textBox10.Text);
                }
                else
                {
                    if (sist1 == 2)
                    {
                        a1 = Convert.ToInt64(textBox10.Text, 2);
                    }
                    else
                    {
                        if (sist1 == 8)
                        {
                            a1 = Convert.ToInt64(textBox10.Text, 8);
                        }
                        else
                        {
                            a1 = Convert.ToInt64(textBox10.Text, 16);
                        }
                    }
                }

                sist2 = int.Parse(comboBox3.SelectedItem.ToString());
                if (sist2 == 10)
                {
                    a2 = Double.Parse(textBox11.Text);
                }
                else
                {
                    if (sist2 == 2)
                    {
                        a2 = Convert.ToInt64(textBox11.Text, 2);
                    }
                    else
                    {
                        if (sist2 == 8)
                        {
                            a2 = Convert.ToInt64(textBox11.Text, 8);
                        }
                        else
                        {
                            a2 = Convert.ToInt64(textBox11.Text, 16);
                        }
                    }
                }

                operation = comboBox4.SelectedItem.ToString();
                if (operation == "+")
                {
                    textBox12.Text = Convert.ToString(a1 + a2);
                }
                if (operation == "-")
                {
                    textBox12.Text = Convert.ToString(a1 - a2);
                }
                if (operation == "/")
                {
                    if (a2 != 0)
                    {
                        textBox12.Text = Convert.ToString(a1 / a2);
                    }
                    else
                    {
                        MessageBox.Show("На 0 делить нельзя!");
                    }
                }
                if (operation == "*")
                {
                    textBox12.Text = Convert.ToString(a1 * a2);
                }

                if (textBox12.Enabled == false)
                {
                    textBox12.Enabled = true;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox10.Enabled == false)
            {
                textBox10.Enabled = true;
                comboBox3.Enabled = true;
            }
            textBox10.Text = "";
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (comboBox2.SelectedItem.ToString() == "10")
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //цифры, клавиша BackSpace, запятая и минус в ASCII 
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (comboBox2.Text.ToString() == "16")
                {
                    if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 96 || e.KeyChar >= 103)) //цифры, клавиша BackSpace, a - z
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (comboBox2.Text.ToString() == "2")
                    {
                        if ((e.KeyChar <= 47 || e.KeyChar >= 50) && number != 8) //цифры, клавиша BackSpace
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        if ((e.KeyChar <= 47 || e.KeyChar >= 56) && number != 8) //цифры, клавиша BackSpace
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (comboBox3.SelectedItem.ToString() == "10")
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //цифры, клавиша BackSpace, запятая и минус в ASCII 
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (comboBox3.Text.ToString() == "16")
                {
                    if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 96 || e.KeyChar >= 103)) //цифры, клавиша BackSpace, a - z
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (comboBox3.Text.ToString() == "2")
                    {
                        if ((e.KeyChar <= 47 || e.KeyChar >= 50) && number != 8) //цифры, клавиша BackSpace
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        if ((e.KeyChar <= 47 || e.KeyChar >= 56) && number != 8) //цифры, клавиша BackSpace
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                button1.Enabled = true;
                textBox1.Enabled = true;
            }
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sist = int.Parse(comboBox1.SelectedItem.ToString());
                string z = "";
                n = 1;
                if (sist == 10)
                {
                    chi = Convert.ToDouble(textBox1.Text);
                    ost = chi - Math.Truncate(chi);
                    if (chi < 0)
                    {
                        chi = chi * (-1);
                        
                        z = "-";
                    }
                    else
                    {
                        
                        z = "";
                    }
                    ost = chi - Math.Truncate(chi);
                    if (ost > 0)
                    {
                        n = 2;
                        double[] asd2 = new double[10];
                        asd2[0] = ost;
                        double[] asd8 = new double[10];
                        asd8[0] = ost;
                        double[] asd16 = new double[10];
                        asd16[0] = ost;
                        y2 = "";
                        y8 = y2;
                        y16 = y8;
                        for (int i = 1; i < 10; i++)
                        {
                            asd2[i] = (2 * asd2[i - 1]) - Math.Truncate(asd2[i - 1] * 2);
                            int bin = Convert.ToInt32(Math.Truncate(asd2[i - 1] * 2));
                            y2 += bin;

                            asd8[i] = (8 * asd8[i - 1]) - Math.Truncate(asd8[i - 1] * 8);
                            double oct = Math.Truncate(asd8[i - 1] * 8);
                            y8 += oct;

                            asd16[i] = (16 * asd16[i - 1]) - Math.Truncate(asd16[i - 1] * 16);
                            string hex;
                            hex = Convert.ToString(Math.Truncate(asd16[i - 1] * 16));
                            int ze;
                            ze = Convert.ToInt32(hex);
                            switch (ze)
                            {
                                case 10:
                                    hex = "a";
                                    break;
                                case 11:
                                    hex = "b";
                                    break;
                                case 12:
                                    hex = "c";
                                    break;
                                case 13:
                                    hex = "d";
                                    break;
                                case 14:
                                    hex = "e";
                                    break;
                                case 15:
                                    hex = "f";
                                    break;
                                default:
                                    break;
                            }
                            y16 += hex;
                        }
                    }
                    else
                    {
                        n = 1;
                        if (z == "")
                        {
                            x10 = Int64.Parse(textBox1.Text);
                        }
                        else
                        {
                            x10 = Int64.Parse(textBox1.Text) * (-1);
                        }
                    }
                }
                else
                {
                    if (sist == 2)
                    {
                        x10 = Convert.ToInt64(textBox1.Text, 2);
                    }
                    else
                    {
                        if (sist == 8)
                        {
                            x10 = Convert.ToInt64(textBox1.Text, 8);
                        }
                        else
                        {
                            x10 = Convert.ToInt64(textBox1.Text, 16);
                        }
                    }
                }
                if (n == 1)
                {
                    textBox2.Text = z + Convert.ToString(x10, 2);
                    textBox3.Text = z + Convert.ToString(x10, 8);
                    textBox4.Text = z + x10.ToString();
                    textBox5.Text = z + Convert.ToString(x10, 16);
                }
                else
                {
                    textBox2.Text = z + Convert.ToString(Convert.ToInt64(Math.Truncate(chi)), 2) + "," + y2;
                    textBox3.Text = z + Convert.ToString(Convert.ToInt64(Math.Truncate(chi)), 8) + "," + y8;
                    textBox4.Text = textBox1.Text;
                    textBox5.Text = z + Convert.ToString(Convert.ToInt64(Math.Truncate(chi)), 16) + "," + y16;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (comboBox1.SelectedItem.ToString() == "10")
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace, запятая и минус в ASCII 
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (comboBox1.Text.ToString() == "16")
                {
                    if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 96 || e.KeyChar >= 103)) //цифры, клавиша BackSpace, a - z
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (comboBox1.Text.ToString() == "2")
                    {
                        if ((e.KeyChar <= 47 || e.KeyChar >= 50) && number != 8) //цифры, клавиша BackSpace
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        if ((e.KeyChar <= 47 || e.KeyChar >= 56) && number != 8) //цифры, клавиша BackSpace
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }
    }
}

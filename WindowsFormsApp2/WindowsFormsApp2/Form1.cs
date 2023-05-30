using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox6_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox8_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void label4_Click(object sender, EventArgs e)
        //{

        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void label7_Click(object sender, EventArgs e)
        //{

        //}

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

       


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int size = int.Parse(EnteredSize.Text);
                if (size > 1 && size < 67)
                {
                    if (RegionComboBox1.SelectedItem != null && RegionComboBox2.SelectedItem != null)
                    {
                        string variant = RegionComboBox1.SelectedItem.ToString();
                        string to = RegionComboBox2.SelectedItem.ToString();
                        Calculator converter = new Calculator();
                        double result = converter.ConvertResult(size, variant, to);
                                    ResultTextBox.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Выбрите регион ввода и вывода!");
                    }
                }
                else
                {
                    MessageBox.Show("Размер должен быть больше 1 и меньше 67!");
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Недопустимый формат ввода!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
            }
        }
        public class Calculator
        {
            public int ConvertResult(int size, string variant, string to)
            {
                int result = 0;
                switch (variant)
                {
                    case "RUS/BEL":
                        switch (to)
                        {
                            case "UK/USA":
                                result = size - 38;
                                break;
                            case "EU":
                                result = size - 6;
                                break;
                        }
                        break;
                    case "UK/USA":
                        switch (to)
                        {
                            case "RUS/BEL":
                                result = size + 38;
                                break;
                            case "EU":
                                result = size + 32;
                                break;
                        }
                        break;
                    case "EU":
                        switch (to)
                        {
                            case "RUS/BEL":
                                result = size + 6;
                                break;
                            case "UK/USA":
                                result = size - 32;
                                break;
                        }
                        break;
                }
                return result;
            }

           
        }
    } 
}
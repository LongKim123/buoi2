using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            float price = 0;
            for (int i = 0; i < groupBox1.Controls.Count;i++)
            {
                if(groupBox1.Controls[i] is Button)
                {
                    Button btn = (Button)groupBox1.Controls[i];
                    if (btn.BackColor == Color.Blue)
                    {
                        btn.BackColor = Color.Yellow;
                       // btn.ForeColor = Color.Black;

                        if (btn.Text == "1" || btn.Text == "2" || btn.Text == "3" || btn.Text == "4" || btn.Text == "5")
                        {
                            price = price + 5000;
                            
                        }

                        else if (btn.Text == "6" || btn.Text == "7" || btn.Text == "8" || btn.Text == "9" || btn.Text == "10")
                        {
                            price = price + 6500;
                        }

                        else if (btn.Text == "11" || btn.Text == "12" || btn.Text == "13" || btn.Text == "14" || btn.Text == "15")
                        {
                            price = price + 8000;
                        }
                        
                    }
                    textBox1.Text = price.ToString();

                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

          
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Chontungcai(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
            }
            else if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show(" ghe da duoc chon");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < groupBox1.Controls.Count;i++)
            {
                if(groupBox1.Controls[i] is Button)
                {
                    Button btn = (Button)groupBox1.Controls[i];
                    if(btn.BackColor==Color.Blue)
                    {
                        btn.BackColor = Color.White;
                    }
                }
            }
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

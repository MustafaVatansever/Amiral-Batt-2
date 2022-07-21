using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Amiral_Battı_2
{
    public partial class Form3 : Form 
    {
        public Form3()
        {
            InitializeComponent();
        }
           int count = 0;
         

           private void Form3_Load(object sender, EventArgs e)
           {
            comboBox1.SelectedItem = comboBox1.Items[0];
            for (int b = 0; b < 10; b++)
                {
                   for (int j = 0; j < 10; j++)
                   {
                      Button btn = new Button();
                    Gemi.gemilerim[count] = btn;
                      btn.Name = count.ToString();
                      btn.Size = new Size(30, 30);
                      btn.Location = new Point(50 + (30 * j), 50 + (30 * b));
                      Controls.Add(btn);
                    count++;
                      btn.Click += new EventHandler(Btn_Click);
                   }
                }
           }


        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (comboBox1.SelectedItem =="5*1 Kruvazor")
            {
                if (comboBox2.SelectedItem == "DİKEY")
                {
                    for (int i = Convert.ToInt32(b.Name); i < Convert.ToInt32(b.Name) + 41; i += 10)
                    {
                        if (Gemi.gemilerim[i].BackColor == Color.Green || Gemi.gemilerim[i].BackColor == Color.Red)
                        {
                            MessageBox.Show("Daha Önce Koyduğunuz Gemiyle Çarpışıyor");
                            return;
                        }
                        else
                        {
                            Gemi.Butonlar[i] = 1;
                            Gemi.gemilerim[i].BackColor = Color.Green;
                        }
                    }
                }
                else
                {
                    for (int i = Convert.ToInt32(b.Name); i < Convert.ToInt32(b.Name) + 5; i++)
                    {
                        if (Gemi.gemilerim[i].BackColor == Color.Green || Gemi.gemilerim[i].BackColor == Color.Red)
                        {
                            MessageBox.Show("Daha Önce Koyduğunuz Gemiyle Çarpışıyor");
                            return;
                        }
                        else
                        {
                            Gemi.Butonlar[i] = 1;
                            Gemi.gemilerim[i].BackColor = Color.Green;
                        }
                    }
                        
                }
                comboBox1.Items.Remove("5*1 Kruvazor");
            }


            if (comboBox1.SelectedItem == "4*1 Savaş Gemisi")
            {
                if (comboBox2.SelectedItem == "DİKEY")
                {
                    for (int i = Convert.ToInt32(b.Name); i < Convert.ToInt32(b.Name) + 31; i += 10)
                    {
                        if (Gemi.gemilerim[i].BackColor == Color.Green || Gemi.gemilerim[i].BackColor == Color.Red)
                        {
                            MessageBox.Show("Daha Önce Koyduğunuz Gemiyle Çarpışıyor");
                            return;
                        }
                        else
                        {
                            Gemi.Butonlar[i] = 1;
                            Gemi.gemilerim[i].BackColor = Color.Green;
                        }
                    }
                }
                else
                {
                    for (int i = Convert.ToInt32(b.Name); i < Convert.ToInt32(b.Name) + 4; i++)
                    {
                        if (Gemi.gemilerim[i].BackColor == Color.Green || Gemi.gemilerim[i].BackColor == Color.Red)
                        {
                            MessageBox.Show("Daha Önce Koyduğunuz Gemiyle Çarpışıyor");
                            return;
                        }
                        else
                        {
                            Gemi.Butonlar[i] = 1;
                            Gemi.gemilerim[i].BackColor = Color.Green;
                        }
                    }

                }
                comboBox1.Items.Remove("4*1 Savaş Gemisi");
            }


            if (comboBox1.SelectedItem == "3*1 Yük Gemisi")
            {
                if (comboBox2.SelectedItem == "DİKEY")
                {
                    for (int i = Convert.ToInt32(b.Name); i < Convert.ToInt32(b.Name) + 21; i += 10)
                    {
                        if (Gemi.gemilerim[i].BackColor == Color.Green || Gemi.gemilerim[i].BackColor == Color.Red)
                        {
                            MessageBox.Show("Daha Önce Koyduğunuz Gemiyle Çarpışıyor");
                            return;
                        }
                        else
                        {
                            Gemi.Butonlar[i] = 1;
                            Gemi.gemilerim[i].BackColor = Color.Green;
                        }
                    }
                }
                else
                {
                    for (int i = Convert.ToInt32(b.Name); i < Convert.ToInt32(b.Name) + 3; i++)
                    {
                        if (Gemi.gemilerim[i].BackColor == Color.Green || Gemi.gemilerim[i].BackColor == Color.Red)
                        {
                            MessageBox.Show("Daha Önce Koyduğunuz Gemiyle Çarpışıyor");
                            return;
                        }
                        else
                        {
                            Gemi.Butonlar[i] = 1;
                            Gemi.gemilerim[i].BackColor = Color.Green;
                        }
                    }
                }
                comboBox1.Items.Remove("3*1 Yük Gemisi");
            }


            if (comboBox1.SelectedItem == "2*1 Yolcu Gemisi")
            {
                if (comboBox2.SelectedItem == "DİKEY")
                {
                    for (int i = Convert.ToInt32(b.Name); i < Convert.ToInt32(b.Name) + 11; i += 10)
                    {
                        if (Gemi.gemilerim[i].BackColor == Color.Green || Gemi.gemilerim[i].BackColor == Color.Red)
                        {
                            MessageBox.Show("Daha Önce Koyduğunuz Gemiyle Çarpışıyor");
                            return;
                        }
                        else
                        {
                            Gemi.Butonlar[i] = 1;
                            Gemi.gemilerim[i].BackColor = Color.Green;
                        }
                    }
                }
                else
                {
                    for (int i = Convert.ToInt32(b.Name); i < Convert.ToInt32(b.Name) + 2; i++)
                    {
                        if (Gemi.gemilerim[i].BackColor == Color.Green || Gemi.gemilerim[i].BackColor == Color.Red)
                        {
                            MessageBox.Show("Daha Önce Koyduğunuz Gemiyle Çarpışıyor");
                            return;
                        }
                        else
                        {
                            Gemi.Butonlar[i] = 1;
                            Gemi.gemilerim[i].BackColor = Color.Green;
                        }
                    }
                }
                comboBox1.Items.Remove("2*1 Yolcu Gemisi");
            }
            if (comboBox1.Items.Count > 0 && comboBox1.SelectedIndex < 0)
                comboBox1.SelectedItem = comboBox1.Items[0];
        }


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1001_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Close();
            form4.Show();
        }
    }
}


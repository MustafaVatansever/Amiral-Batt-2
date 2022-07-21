using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Amiral_Battı_2
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
 
        private void Form2_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = true;
            Random rastgele = new Random();
            int Id = rastgele.Next(0, 999999);
            textBox3.Text = Convert.ToString(Id);
        }

        public void threads()
        {
            Thread t;
            
                t = new Thread(connect);
            
            t.Start();
        }

        bool baglanti = false;
        public void connect()
        {

            if (Oyuncu.Host)
            {
                if (!Oyuncu.HostBaglanti())
                {
                    MessageBox.Show("Şuan aktif oyuncu bulunmamaktadır");
                }
                else
                {
                    baglanti = true;
                  /*  this.Invoke((MethodInvoker)delegate
                    {
                        this.Close(); 
                    }); */
                    
                }
            }
            else
            {
                if (!Oyuncu.ClientBaglanti())
                {
                    MessageBox.Show("Şuan kurulu oda bulunmamaktadır lütfen önce yeni oda açınız");
                }
                else
                {
                    baglanti = true;
                 
                }
            }

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox2.Visible = true;
            radioButton1.Checked = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
                Oyuncu.Host = true;
            else
                Oyuncu.Host = false;

            threads();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (baglanti)
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.Show();
            }
        }
    }
}

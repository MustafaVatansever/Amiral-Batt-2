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
   
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int count = 0;
        int cur;
        int loc = 0;
        int Hostkalan = 16;
        int Clientkalan = 16;
        bool sira;
        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "16 Adet Kaldı";
            if (Oyuncu.Host)
            {
                sira = true;
                label2.Text ="Host";
            }
            else
            {
                sira = false;
                label2.Text ="Client";
            }
            threads();
            
            for (int b = 0; b < 10; b++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    Gemi.but[loc] = btn;
                    loc++;
                    btn.Name = Convert.ToString(count);
                    btn.Size = new Size(30, 30);
                    btn.Location = new Point(50 + (30 * j), 50 + (30 * b));
                    Controls.Add(btn);
                    count++;
                    btn.Click += new EventHandler(Btn_Click);
                }
            }

            loc = 0;
            count = 0;
            for (int b = 0; b < 10; b++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Name = count.ToString();
                    Gemi.gemilerim[loc] = btn;
                    btn.Name = Convert.ToString(count);
                    btn.Size = new Size(30, 30);
                    btn.Location = new Point(550 + (30 * j), 50 + (30 * b));
                    if (Gemi.Butonlar[loc] == 1)
                    {
                        btn.BackColor = Color.Green;
                    }
                    else
                    {
                        btn.BackColor = Color.Red;
                    } 
                    Controls.Add(btn);
                    loc++;
                    count++;
                  //  btn.Click += new EventHandler(Btn_Click);
                }
            }

        }
        public void threads()
        {
            Thread t;
            if (Oyuncu.Host)
            {
                t = new Thread(new ThreadStart(Hostrun));
            }
            else
            {
                t = new Thread(new ThreadStart(Clientrun));
            }
            t.Start();
        }

        public void Hostrun()
        {
            while (true)
            {
                string butonisaretle = Oyuncu.HostingButongetir();

                string[] ss = butonisaretle.Split(' ');
                if (ss[0] == "A")
                {
                    if (ss[1] == "Green")
                    {
                        Gemi.but[cur].BackColor = Color.Green;
                        Hostkalan--;
                        label1.Invoke((MethodInvoker)delegate
                        {
                            label1.Text = Hostkalan + " adet kaldı";
                        });
                        if (Hostkalan == 0)
                        {
                            DialogResult result = MessageBox.Show("TEBRİKLER Oyunu Kazandınız.  Tekrar Oynamak İster Misiniz ? ", "Program Uyarısı",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button3);
                            if (result == DialogResult.Yes)
                            {
                                Application.Restart();
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                    }
                    if (ss[1] == "Red")
                        Gemi.but[cur].BackColor = Color.Red;
                }
                else
                {
                    Console.WriteLine(butonisaretle);
                    if (Gemi.Butonlar[Convert.ToInt32(butonisaretle)] == 1)
                    {
                        Oyuncu.HostingButonGotur("A Green");
                        Gemi.Butonlar[Convert.ToInt32(butonisaretle)]++;
                        Clientkalan--;
                        if (Clientkalan == 0)
                        {
                            DialogResult result = MessageBox.Show("OYUNU KAYBETTİNİZ   Tekrar Oynamak İster Misiniz ? ", "Program Uyarısı",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button3);
                            if (result == DialogResult.Yes)
                            {
                                Application.Restart();
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                    }
                    else if (Gemi.Butonlar[Convert.ToInt32(butonisaretle)] == 0)
                    {
                        Oyuncu.HostingButonGotur("A Red");
                        Gemi.Butonlar[Convert.ToInt32(butonisaretle)] += 2;
                    }
                    Gemi.gemilerim[Convert.ToInt32(butonisaretle)].BackColor = Color.Black;
                    sira = true;
                }
            }
        }
        
        public void Clientrun()
        {
            while (true)
            {
                string butonisaretle = Oyuncu.ClientButonGetir();
                string[] ss = butonisaretle.Split(' ');

                if (ss[0] == "A")
                {
                    if (ss[1] == "Green")
                    {
                        Gemi.but[cur].BackColor = Color.Green;
                        Clientkalan--;
                        label1.Invoke((MethodInvoker)delegate
                        {
                            label1.Text = Clientkalan + " adet kaldı";
                        });
                        if (Clientkalan == 0)
                        {
                            DialogResult result = MessageBox.Show("TEBRİKLER Oyunu Kazandınız.  Tekrar Oynamak İster Misiniz ? ", "Program Uyarısı",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button3);
                            if (result == DialogResult.Yes)
                            {
                                Application.Restart();
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                    }
                    if (ss[1] == "Red")
                        Gemi.but[cur].BackColor = Color.Red;
                }
                else
                {
                    if (Gemi.Butonlar[Convert.ToInt32(butonisaretle)] == 1)
                    {
                        Oyuncu.ClientButonGotur("A Green");
                        Gemi.Butonlar[Convert.ToInt32(butonisaretle)]++;
                        Hostkalan--;
                        if (Hostkalan == 0)
                        {
                            DialogResult result = MessageBox.Show("OYUNU KAYBETTİNİZ   Tekrar Oynamak İster Misiniz ? ", "Program Uyarısı",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button3);
                            if (result == DialogResult.Yes)
                            {
                                Application.Restart();
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                    }
                    else if (Gemi.Butonlar[Convert.ToInt32(butonisaretle)] == 0)
                    {
                        Oyuncu.ClientButonGotur("A Red");
                        Gemi.Butonlar[Convert.ToInt32(butonisaretle)] += 2;
                    }
                    Gemi.gemilerim[Convert.ToInt32(butonisaretle)].BackColor = Color.Black;
                    sira = true;
                }
            }
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            if (!sira)
            {
                return;
            }
           Button b =  sender as Button;
            if (b.BackColor == Color.Red || b.BackColor == Color.Green)
            {
                MessageBox.Show("Zaten vurdunuz");
                return;
            }
            cur = Convert.ToInt32(b.Name);
            if (Oyuncu.Host)
            {
                Oyuncu.HostingButonGotur(b.Name);
            }
            else
            {
                Oyuncu.ClientButonGotur(b.Name);
            }
            sira = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    } 
}

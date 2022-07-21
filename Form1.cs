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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Her oyuncu kendi gemi filosunu diğer oyuncudan gizlediği," +
              " önceden yatay ve dikey koordinatların belli olduğu bir alanda oynanır. Oyuncular sırayla koordinat belirtip" +
              " 'atış' yaparak diğer oyuncunun gemilerinin yerlerini bulup batırmaya çalışırlar", "Nasıl Oynanır"
              , MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

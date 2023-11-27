using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isim_arama_1550
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string ad = txtAra.Text;
            for(int i=0;i<listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == ad)

                {
                    MessageBox.Show(listBox1.Items[i].ToString() + "    adlı müsteri bulundu");
                }
            break;
                else
                {
                    MessageBox.Show("öyle biri yok ekleyiniz...");
                }
            }
        }
    }
}

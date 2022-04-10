using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string samohlasky = "aeiouyáéěíóúůý";
            string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzž";
            int pocetsamohlasek = 0, pocetsouhlasek = 0;
            string veta = textBox1.Text;
            veta = veta.ToLower();

            for(int i = 0; i < veta.Length ;i++)
            {
                char znak = veta[i];
                if(samohlasky.Contains(znak)) pocetsamohlasek++;                   
                if (souhlasky.Contains(znak)) pocetsouhlasek++;

            }

            label4.Text = pocetsamohlasek.ToString();
            label5.Text = pocetsouhlasek.ToString();
            label6.Text = (veta.Length - pocetsamohlasek - pocetsouhlasek).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

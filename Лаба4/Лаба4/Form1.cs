using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба4
{
    delegate string DAbout(string S);
    public partial class Form1 : Form
    {
        DAbout d;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Pusk_Click(object sender, EventArgs e)
        {
            if (d != null)
            {
                string res = d(Input.Text);
                Output.Text = res;
            }
            else
            {
                MessageBox.Show("Нажмите на одну из кнопок:1-3");
            }
           
        }
        string Metod1(string S)
        {
            return S.ToUpper();
        }
        string Metod2(string S)
        {
            return S.ToLower();
        }
        string Metod3(string S)
        {
            char[] s = S.ToCharArray();
            Array.Reverse(s);
            return new string(s);
        }

        private void Del1_Click(object sender, EventArgs e)
        {
            d = Metod1;
        }

        private void Del2_Click(object sender, EventArgs e)
        {
            d = Metod2;
        }

        private void Del3_Click(object sender, EventArgs e)
        {
            d = Metod3;
        }
    }
}

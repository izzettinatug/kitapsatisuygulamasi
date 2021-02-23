using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alisveris_tutar_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt32(textBox1.Text);
            if (kitapadet >= 0 && kitapadet <= 20)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.20);
                label3.Text = toplam + " TL  ";

            }
            if (kitapadet >= 21 && kitapadet <= 40)
            {

                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.40);
                label3.Text = toplam + " TL ";

            }
            if (kitapadet>= 40 && kitapadet<=60) 
            {

                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.5);
                label3.Text = toplam + " TL ";
            
            }

            if(kitapadet>=60) 
            {

                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.70);
                label3.Text = toplam + " TL ";
            
            
            }
            MessageBox.Show(" Tekrar bekleriz");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
//0-20 =>> % 20
//21-40 =>> % 40
//41-60 =>> %50 
//60++ =>> 70
//Kitap 8 TL

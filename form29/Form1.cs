﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                int sayi = rnd.Next(0, 101);
                lbSayilar.Items.Add(sayi);
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            int aranan = Convert.ToInt32(txtAranan.Text);
            bool bulundu = false;

            for (int i = 0; i < 20; i++)
            {
                int sayi = Convert.ToInt32(lbSayilar.Items[i]);

                if (sayi == aranan)
                {
                    bulundu = true;
                    break; //break komutu döngüden çıkarır.
                }
  
            }
            if (bulundu)
            {
                MessageBox.Show("Aranan sayı bulundu");
            }
            else
            {
                MessageBox.Show("Aranan sayı bulunamadı");
            }
        }   }
}

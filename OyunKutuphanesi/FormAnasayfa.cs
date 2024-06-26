﻿using System;
using System.Windows.Forms;

namespace OyunKutuphanesi
{
    public partial class FormAnasayfa : Form
    {
        FormOyunEkle formOyunEkle;
        FormTumOyunlar formTumOyunlar;
        public FormAnasayfa()
        {
            InitializeComponent();
            
        }

        private void btn_oyunekle_Click(object sender, EventArgs e)
        {
            formOyunEkle.ShowDialog();
        }

        private void FormAnasayfa_Load(object sender, EventArgs e)
        {
            formOyunEkle = new FormOyunEkle();
            formTumOyunlar = new FormTumOyunlar();

        }

        private void btn_tumOyunlar_Click(object sender, EventArgs e)
        {
            formTumOyunlar.ShowDialog();
        }
    }
}

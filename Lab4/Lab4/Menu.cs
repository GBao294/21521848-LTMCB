﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 f = new Bai1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 f = new Bai2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3 f = new Bai3();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai5 f = new Bai5();
            f.Show();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            Bai4 f = new Bai4();
            f.Show();
        }
    }
}

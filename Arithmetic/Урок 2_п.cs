﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic
{
    public partial class Урок_2_п : Form
    {
        public Урок_2_п()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Урок_2 урок_2 = new Урок_2();
            this.Hide();
            урок_2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer ss = new SoundPlayer(Properties.Resources._34);
            // Load the sound
            ss.Load();
            // Play the sound synchronously
            ss.PlaySync();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");

        }
        public void test()
        {
            Console.WriteLine("Test");
            Console.WriteLine("hi");
        }
        public void Html()
        {
            Console.WriteLine("Branch");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
           Undo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

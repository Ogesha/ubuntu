﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kersach
{
    public partial class FormEditAccount : Form
    {
        public FormEditAccount()
        {
            InitializeComponent();
        }

        private void FormEditWorker_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void FormEditAccount_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiXe
{
    public partial class vLogin : Form
    {
        public vLogin()
        {
            InitializeComponent();
        }

        private void vLogin_Load(object sender, EventArgs e)
        {

        }

        private void DANGNHAP_Click(object sender, EventArgs e)
        {
            vInOut v = new vInOut();
            this.Hide();
            v.ShowDialog();
            this.Show();
        }
    }
}

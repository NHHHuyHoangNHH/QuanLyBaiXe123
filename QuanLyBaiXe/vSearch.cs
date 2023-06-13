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
    public partial class vSearch : Form
    {
        public vSearch()
        {
            InitializeComponent();
        }

        private void bt_InOut_Click(object sender, EventArgs e)
        {
            vInOut v = new vInOut();
            this.Hide();
            v.ShowDialog();
            this.Show();
        }

        private void bt_VIP_Click(object sender, EventArgs e)
        {
            vVIP v = new vVIP();
            this.Hide();
            v.ShowDialog();
            this.Show();
        }

        private void bt_Revenue_Click(object sender, EventArgs e)
        {
            vRevenue v = new vRevenue();
            this.Hide();
            v.ShowDialog();
            this.Show();
        }

        private void bt_Log_Click(object sender, EventArgs e)
        {
            vLog v = new vLog();
            this.Hide();
            v.ShowDialog();
            this.Show();
        }

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

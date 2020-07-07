﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hi_TechDistribution.GUI
{
    public partial class SalesCustomer : Form
    {
        public SalesCustomer()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp mysign = new SignUp();
            mysign.Show();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers mypage = new Customers();
            mypage.Show();
        }
    }
}

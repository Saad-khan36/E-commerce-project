﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class User_Account : Form
    {
        public User_Account()
        {
            InitializeComponent();
        }
        public void clear()
        {
            fullnametxt.Clear();
            passwordtxt.Clear();
            confrimpasswordtxt.Clear();
            rolebox.Text = "";
            fullnametxt.Focus();
            usernametext.Clear();
            Savebtn.Enabled = true;
            cancelbtn.Enabled = false;

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void changecancelbtn_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
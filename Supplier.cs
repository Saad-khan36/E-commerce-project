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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void addproductbtn_Click(object sender, EventArgs e)
        {
            suppliermodule suppliermodule = new suppliermodule();   
            suppliermodule.ShowDialog();
        }
    }
}

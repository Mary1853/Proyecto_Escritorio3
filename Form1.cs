﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escritorio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }






















        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Total=0.0;
            if(chkCocina.Checked==true)
                Total = Total + Convert.ToDouble(chkCocina.Text);
            if (chkRefrigeradora.Checked == true)
                Total = Total + Convert.ToDouble(chkRefrigeradora.Text);
            if (chkTelevisor.Checked == true)
                Total = Total + Convert.ToDouble(chkCocina.Text);

        }
    }
}

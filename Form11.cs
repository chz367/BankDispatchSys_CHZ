﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarManager.HelpForm
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        /// <summary>
        /// “确定”
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            /*this.Visible = true;*/
            this.Close();
        }

        /// <summary>
        /// “取消”
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

﻿//
// Larry Nguyen 9/27/2019
// CIS262AD Fall 2019
// Class 35772
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void States_SelectedIndexChanged(object sender, EventArgs e)
        {
            States.Items.Remove(States.SelectedItem);
        }
    }
}
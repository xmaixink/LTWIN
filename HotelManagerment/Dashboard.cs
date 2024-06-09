﻿using HotelManagerment.All_user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagerment
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        /*private void Dashboard_Load(object sender, EventArgs e)
        {
            btnAddRoom.PerformClick();
        }*/
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            uc_control.Visible = true;
            uc_control.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            /* Form1 main = new Form1();
            this.Hide();
            main.ShowDialog();*/
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Hide();
            main.ShowDialog();
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            btnAddRoom.PerformClick();
            uc_control.Visible = false;

        }
    }
}
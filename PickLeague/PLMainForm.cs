﻿using PickLeague.src.main.plData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickLeague {
    public partial class PLMainForm : Form {
        Season currSeason;

        public PLMainForm(Season season) {
            currSeason = season;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}

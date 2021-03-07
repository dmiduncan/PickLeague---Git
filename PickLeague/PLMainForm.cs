using PickLeague.src.main.pickLeagueIO.outbound;
using PickLeague.src.main.plData;
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

        private void PLMainForm_SaveClick(object sender, EventArgs e) {
            string path = "";
            // Test change for commit testing
            SaveFileDialog saveSeasonDialog = new SaveFileDialog();
            saveSeasonDialog.Title = "Save Season File";
            saveSeasonDialog.Filter = "XML files|*.xml";
            saveSeasonDialog.InitialDirectory = @"C:\Program Files (x86)\PickLeague\Seasons";
            try {
                if (saveSeasonDialog.ShowDialog() == DialogResult.OK) {
                    path = saveSeasonDialog.FileName;
                    PLXmlWriter.generateOutboundXml(currSeason, path);
                }
            } catch (Exception loadException) {
                Console.WriteLine(loadException.StackTrace);
                MessageBox.Show("Error saving file. Double check the path or file name.");
            }
        }

        private void PLMainForm_Close(object sender, EventArgs e) {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}

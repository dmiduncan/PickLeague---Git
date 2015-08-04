using PickLeague.src.main.pickLeagueIO.inbound;
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
    public partial class PLSplash : Form {
        private Season currSeason;

        public PLSplash() {
            InitializeComponent();
        }

        private void PLSplash_Load(object sender, EventArgs e) {

        }

        private void PLSplash_Enter(object sender, EventArgs e) {
            string value = getSelectedPLLoadOptionOn();
            bool proceedToClose = false;
            
            if (string.Equals(PLConstants.LO_LOAD_SEASON, value)) {
                string path = "";
                OpenFileDialog loadSeasonDialog = new OpenFileDialog();
                loadSeasonDialog.Title = "Open Season File";
                loadSeasonDialog.Filter = "XML files|*.xml";
                loadSeasonDialog.InitialDirectory = @"C:\Program Files (x86)\PickLeague\Seasons";
                if (loadSeasonDialog.ShowDialog() == DialogResult.OK) {
                    path = loadSeasonDialog.FileName;
                    currSeason = PLXmlParser.parseXmlIntoSeason(path);
                    proceedToClose = true;                           
                }                    
            } else if (string.Equals(PLConstants.LO_NEW_SEASON, value)) {
                currSeason = new Season();
                proceedToClose = true;
            }

            if (proceedToClose) {
                this.Close();
            }
        }

        // Closes the application if the close button is clicked on the splash.
        private void PLSplash_Close(object sender, EventArgs e) {
            Application.Exit();
        }

        public Season getLoadSeason() {
            return currSeason;
        }
    }
}

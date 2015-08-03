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

            if (string.Equals(PLConstants.LO_LOAD_SEASON, value)) {
                currSeason = PLXmlParser.parseXmlIntoSeason();
            } else if (string.Equals(PLConstants.LO_NEW_SEASON, value)) {
                currSeason = new Season();
            }

            this.Close();
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

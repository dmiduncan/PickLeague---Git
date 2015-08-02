using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickLeague.src.main.plData {
    class Week {

        private string weekID;
        private string weekTitle;
        // Matchup ID to Matchup
        private List<Matchup> matchupList;

        public Week() {
            matchupList = new List<Matchup>();
        }

        public string getWeekID() {
            return this.weekID;
        }

        public void setWeekID(string id) {
            this.weekID = id;
        }

        public List<Matchup> getMatchupList() {
            return this.matchupList;
        }

        public void setMatchupList(List<Matchup> matchups) {
            this.matchupList = matchups;
        }
    }
}

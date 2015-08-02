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
        private Dictionary<string, Matchup> matchupList;

        public Week(string id, string title) {
            this.weekID = id;
            this.weekTitle = title;
        }

        public string getWeekID() {
            return this.weekID;
        }

        public void setWeekID(string id) {
            this.weekID = id;
        }

        public string getWeekTitle() {
            return this.weekTitle;
        }

        public void setWeekTitle(string title) {
            this.weekTitle = title;
        }

        public Dictionary<string, Matchup> getMatchupList() {
            return this.matchupList;
        }

        public void setMatchupList(Dictionary<string, Matchup> matchups) {
            this.matchupList = matchups;
        }
    }
}

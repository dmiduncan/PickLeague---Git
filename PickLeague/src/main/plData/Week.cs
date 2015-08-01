using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickLeague.src.main.plData {
    class Week {

        private string weekID;
        private string weekTitle;
        private List<Matchup> matchupList;

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

        public List<Matchup> getMatchupList() {
            return this.matchupList;
        }

        public void setMatchupList(List<Matchup> matchups) {
            this.matchupList = matchups;
        }
    }
}

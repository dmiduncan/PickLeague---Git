using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickLeague {
    class Matchup {
        
        private string homeTeamID;
        private string awayTeamID;
        private string matchupID;

        public Matchup(string home, string away, string id) {
            this.homeTeamID = home;
            this.awayTeamID = away;
            this.matchupID = id;
        }

        public string getHomeTeamID() {
            return this.homeTeamID;
        }

        public void setHomeTeamID(string home) {
            this.homeTeamID = home;
        }

        public string getAwayTeamID() {
            return this.awayTeamID;
        }

        public void setAwayTeamID(string away) {
            this.awayTeamID = away;
        }

        public string getMatchupID() {
            return this.matchupID;
        }

        public void setMatchupID(string id) {
            this.matchupID = id;
        }
    }
}

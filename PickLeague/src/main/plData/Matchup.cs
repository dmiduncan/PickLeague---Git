using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickLeague.src.main.plData {
    class Matchup {
        
        private string homeTeamID;
        private string awayTeamID;
        private string matchupID;
        private string winnerID;

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

        public string getWinnerID() {
            return this.winnerID;
        }

        public void setWinnerID(string id) {
            this.winnerID = id;
        }
    }
}

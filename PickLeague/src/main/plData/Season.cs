using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickLeague.src.main.plData {
    public class Season {
        
        private Dictionary<string, Week> weekDict;
        // this will either be set based on inbound value or set if new season is generated
        private string seasonID;
        private List<Player> playerList;

        public Season() {
            playerList = new List<Player>();
            weekDict = new Dictionary<string, Week>();
        }  
        
        public Dictionary<string, Week> getWeekDict() {
            return this.weekDict;
        }              

        public void setWeekDict(Dictionary<string, Week> weeks) {
            this.weekDict = weeks;
        }

        public List<Player> getPlayerList() {
            return this.playerList;
        }

        public void setPlayerList(List<Player> players) {
            this.playerList = players;
        }

        public string getSeasonID() {
            return this.seasonID;
        }

        public void setSeasonID(string id) {
            this.seasonID = id;
        }
    }
}

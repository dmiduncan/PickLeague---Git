using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickLeague.src.main.plData {
    class Team {

        private string teamName;
        private string teamID;

        public string getTeamName() {
            return this.teamName;
        }

        public void setTeamName(string name) {
            this.teamName = name;
        }

        public string getTeamID() {
            return this.teamID;
        }

        public void setTeamID(string id) {
            this.teamID = id;
        }
    }
}

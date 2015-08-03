using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickLeague.src.main.plData {
    public class Player {

        private string playerID;
        private string firstName;
        private string lastName;
        private int winsTotal;
        private int lossesTotal;

        public Player() {
            this.winsTotal = 0;
            this.lossesTotal = 0;
        }

        public string getPlayerID() {
            return this.playerID;
        }

        public void setPlayerID(string id) {
            this.playerID = id;
        }

        public string getFirstName() {
            return this.firstName;
        }

        public void setFirstName(string first) {
            this.firstName = first;
        }

        public string getLastName() {
            return this.lastName;
        }

        public void setLastName(string last) {
            this.lastName = last;
        }

        public int getWinsTotal() {
            return this.winsTotal;
        }

        public void setWinsTotal(int wins) {
            this.winsTotal = wins;
        }

        public int getLossesTotal() {
            return this.lossesTotal;
        }

        public void setLossesTotal(int losses) {
            this.lossesTotal = losses;
        }
    }
}

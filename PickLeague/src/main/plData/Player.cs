using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickLeague {
    class Player {
        private string firstName;
        private string lastName;
        private int winsTotal;
        private int lossesTotal;
        private Dictionary<string, int> winTotalForGivenWeek;

        public Player(string first, string last) {
            this.firstName = first;
            this.lastName = last;
            this.winsTotal = 0;
            this.lossesTotal = 0;
            winTotalForGivenWeek = new Dictionary<string, int>();
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

        public Dictionary<string, int> getWinTotalForGivenWeekDict() {
            return this.winTotalForGivenWeek;
        }

        public void setWinTotalForGivenWeekDict(Dictionary<string, int> winTotalDict) {
            this.winTotalForGivenWeek = winTotalDict;
        }
    }
}

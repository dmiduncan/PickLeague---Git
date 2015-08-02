using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickLeague.src.main.plData {
    class Season {

        // Dictionary formed of the Week ID to the Week
        private Dictionary<string, Week> weekDict;
        private string seasonID;

        public Season(string id) {
            weekDict = new Dictionary<string, Week>();
            seasonID = id;
        }  
        
        public Dictionary<string, Week> getWeekDict() {
            return this.weekDict;
        }              

        public void setWeekDict(Dictionary<string, Week> weeks) {
            this.weekDict = weeks;
        }

        public string getSeasonID() {
            return this.seasonID;
        }

        public void setSeasonID(string id) {
            this.seasonID = id;
        }
    }
}

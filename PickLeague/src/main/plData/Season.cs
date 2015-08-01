using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickLeague {
    class Season {

        private Dictionary<string, Week> weekDict;

        public Season() {
            weekDict = new Dictionary<string, Week>();
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickLeague {
    static class PLConstants {

        public static readonly string DO_PLAYER_CONTAINER = "PLAYERS";
        public static readonly string DO_WEEK_CONTAINER = "WEEKS";

        public static readonly string DO_PLAYER = "PLAYER";
        public static readonly string DO_MATCHUP = "MATCHUP";
        public static readonly string DO_WEEK = "WEEK";
        public static readonly string DO_SEASON = "SEASON";

        // Player Values
        public static readonly string PV_FIRST = "FIRSTNAME";
        public static readonly string PV_LAST = "LASTNAME";
        public static readonly string PV_PLAYER_ID = "PLAYERID";
        public static readonly string PV_PLAYER_WINS = "WINS";
        public static readonly string PV_PLAYER_LOSSES = "LOSSES";

        // Matchup Values
        public static readonly string MV_HOME_TEAM_ID = "HOMETEAM";
        public static readonly string MV_AWAY_TEAM_ID = "AWAYTEAM";
        public static readonly string MV_MATCHUP_ID = "MATCHUPID";
        public static readonly string MV_WINNER_ID = "WINNDERID";

        // Week Values
        public static readonly string WV_WEEK_ID = "WEEKID";

        // Season Values
        public static readonly string SV_SEASON_ID = "SEASONID";

    }
}

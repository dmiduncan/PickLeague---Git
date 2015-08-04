using PickLeague.src.main.plData;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PickLeague.src.main.pickLeagueIO.outbound {
    static class PLXmlWriter {

        public static void generateOutboundXml(Season currSeason, string path) {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineOnAttributes = true;
            // todo add dynamic file saving.
            XmlWriter writer = XmlWriter.Create(path, settings);

            writer.WriteStartElement(PLConstants.DO_SEASON);
            writer.WriteElementString(PLConstants.SV_SEASON_ID, currSeason.getSeasonID());

            /* ---------------- Player Info ---------------- */
            writer.WriteStartElement(PLConstants.DO_PLAYER_CONTAINER);
            // Writes out the information for each player.
            foreach (Player player in currSeason.getPlayerList()) {
                writer.WriteStartElement(PLConstants.DO_PLAYER);
                writer.WriteElementString(PLConstants.PV_FIRST, player.getFirstName());
                writer.WriteElementString(PLConstants.PV_LAST, player.getLastName());
                writer.WriteElementString(PLConstants.PV_PLAYER_ID, player.getPlayerID());
                writer.WriteElementString(PLConstants.PV_PLAYER_WINS, player.getWinsTotal().ToString());
                writer.WriteElementString(PLConstants.PV_PLAYER_LOSSES, player.getLossesTotal().ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            /* ---------------- Week Info ---------------- */
            writer.WriteStartElement(PLConstants.DO_WEEK_CONTAINER);
            // Grabs the keys and sorts them in ascending order.
            List<string> keyList = currSeason.getWeekDict().Keys.OrderBy(c => int.Parse(c)).ToList();
            foreach (string key in keyList) {
                Week currWeek = currSeason.getWeekDict()[key];
                writer.WriteStartElement(PLConstants.DO_WEEK);
                writer.WriteElementString(PLConstants.WV_WEEK_ID, currWeek.getWeekID());
                foreach (Matchup matchup in currWeek.getMatchupList()) {
                    writer.WriteStartElement(PLConstants.DO_MATCHUP);
                    writer.WriteElementString(PLConstants.MV_HOME_TEAM_ID, matchup.getHomeTeamID());
                    writer.WriteElementString(PLConstants.MV_AWAY_TEAM_ID, matchup.getAwayTeamID());
                    writer.WriteElementString(PLConstants.MV_MATCHUP_ID, matchup.getMatchupID());
                    writer.WriteElementString(PLConstants.MV_WINNER_ID, matchup.getWinnerID());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }

            writer.Flush();
            writer.Close();
        }
    }
}

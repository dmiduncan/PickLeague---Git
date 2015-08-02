using PickLeague.src.main.plData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PickLeague.src.main.pickLeagueIO.inbound {
    static class XmlParser {

        public static Season parseXmlIntoSeason() {
            Season currSeason = new Season();
            XmlDocument doc = new XmlDocument();

            try {
                string plXmlPath = "C:\\XmlTesting\\test2.xml"; // todo this needs to be made more dynamic
                doc.Load(plXmlPath);
                foreach (XmlNode node in doc.DocumentElement.ChildNodes) {
                    if (nodeEquals(node, PLConstants.SV_SEASON_ID)) {
                        currSeason.setSeasonID(node.InnerText);
                    } else if (nodeEquals(node, PLConstants.DO_PLAYER_CONTAINER)) {
                        foreach (XmlNode playerNode in node.ChildNodes) {
                            parsePlayer(currSeason, playerNode);
                        }
                    } else if (nodeEquals(node, PLConstants.DO_WEEK_CONTAINER)) {
                        foreach (XmlNode weekNode in node.ChildNodes) {
                            parseWeek(currSeason, weekNode);    
                        }
                    }
                }
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                Environment.Exit(0);
            }

            return currSeason;
        }

        public static void parsePlayer(Season currSeason, XmlNode playerNode) {
            Player newPlayer = new Player();
            foreach (XmlNode infoNode in playerNode.ChildNodes) {                
                if (nodeEquals(infoNode, PLConstants.PV_FIRST)) {
                    newPlayer.setFirstName(infoNode.InnerText);
                } else if (nodeEquals(infoNode, PLConstants.PV_LAST)) {
                    newPlayer.setLastName(infoNode.InnerText);
                } else if (nodeEquals(infoNode, PLConstants.PV_PLAYER_ID)) {
                    newPlayer.setPlayerID(infoNode.InnerText);
                } else if (nodeEquals(infoNode, PLConstants.PV_PLAYER_WINS)) {
                    newPlayer.setWinsTotal(Int32.Parse(infoNode.InnerText));
                } else if (nodeEquals(infoNode, PLConstants.PV_PLAYER_LOSSES)) {
                    newPlayer.setLossesTotal(Int32.Parse(infoNode.InnerText));
                }
            }

            currSeason.getPlayerList().Add(newPlayer);
        }

        public static void parseWeek(Season currSeason, XmlNode weekNode) {
            Week newWeek = new Week(); 
            foreach (XmlNode subWeekNode in weekNode.ChildNodes) {
                if (nodeEquals(subWeekNode, PLConstants.WV_WEEK_ID)) {
                    newWeek.setWeekID(subWeekNode.InnerText);
                } else if (nodeEquals(subWeekNode, PLConstants.DO_MATCHUP)) {
                    parseMatchup(newWeek, subWeekNode);
                }
            }

            currSeason.getWeekDict().Add(newWeek.getWeekID(), newWeek);
        }

        public static void parseMatchup(Week currWeek, XmlNode matchupNode) {
            Matchup newMatchup = new Matchup();
            foreach (XmlNode infoNode in matchupNode.ChildNodes) {
                string nodeValue = infoNode.InnerText;
                if (String.IsNullOrEmpty(nodeValue)) {
                    continue;
                }

                if (nodeEquals(infoNode, PLConstants.MV_MATCHUP_ID)) {
                    newMatchup.setMatchupID(nodeValue);
                } else if (nodeEquals(infoNode, PLConstants.MV_HOME_TEAM_ID)) {
                    newMatchup.setHomeTeamID(nodeValue);
                } else if (nodeEquals(infoNode, PLConstants.MV_AWAY_TEAM_ID)) {
                    newMatchup.setAwayTeamID(nodeValue);
                } else if (nodeEquals(infoNode, PLConstants.MV_WINNER_ID)) {
                    newMatchup.setWinnerID(nodeValue);
                }
            }

            currWeek.getMatchupList().Add(newMatchup);
        }

        // Returns true if the node name is the same as the name string passed in.
        public static bool nodeEquals(XmlNode node, string name) {
            return (node.Name != null && name != null 
                && string.Equals(node.Name, name, StringComparison.OrdinalIgnoreCase));
        }
    }
}

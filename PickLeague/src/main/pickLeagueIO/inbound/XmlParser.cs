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
                string plXMLPath = "C:\\XmlTesting\\xmlTest.xml"; // todo adjust this to be flexible based upon where the program is installed.
                foreach (XmlNode node in doc.DocumentElement.ChildNodes) {

                }
            } catch (Exception e) {
                // todo dialog message claiming corrupt save data. Maybe off to load backup from earlier state.
            }

            return currSeason;
        }
    }
}

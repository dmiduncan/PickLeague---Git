using PickLeague.src.main.pickLeagueIO.inbound;
using PickLeague.src.main.pickLeagueIO.outbound;
using PickLeague.src.main.plData;
using System;
using System.Windows.Forms;

namespace PickLeague.main {
    static class PickLeagueMain {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Season currentSeason = PLXmlParser.parseXmlIntoSeason();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PLMainForm());

            PLXmlWriter.generateOutboundXml(currentSeason);
        }
    }
}

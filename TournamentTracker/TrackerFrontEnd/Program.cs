using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerFrontEnd
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TournamentDashBoardForm());
        }
    }
}

    //Relationships FK ----> PK

/* TournamentsEntries ------> Tournaments &&
 * TournamentPrizes -------> Tournaments &&
 * TournamentPrizes -------> Prizes &&
 * TournamentsEntries -----> Teams &&
 * TeamMembers -----> Teams &&
 * TeamMembers -----> People &&
 * Matchups -----> Teams &&
 * MatchupEntries ------> Matchups &&
 * MatchupEntries ------> Teams &&
 */

    //Stored Procedures

/* spMatchupEntries_GetByMatchup
 * spMatchups_GetByTournament
 * spPeople_GetAll
 * spPrizes_GetByTournament
 * spTeam_GetByTournament
 * spTeamMembers_GetByTeam
 * spTournaments_GetAll
 */
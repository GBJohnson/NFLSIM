using System.Collections.Generic;
using NFLSIM.Classes.enums;

namespace NFLSIM.Classes
{
    public class TeamBuilder
    {
        public List<Team> BuildTeams()
        {
            return new List<Team>
            {
                MakeTeam("New England Patriots", "NE", Conference.AFC, Division.East, 0, 5),
                MakeTeam("New York Jets", "NYJ", Conference.AFC, Division.East, 0, 5),
                MakeTeam("Buffalo Bills", "BUF", Conference.AFC, Division.East, 0, 5),
                MakeTeam("Miami Dolphins", "MIA", Conference.AFC, Division.East, 0, 5),
                MakeTeam("Baltimore Ravens", "BAL", Conference.AFC, Division.North, 0, 5),
                MakeTeam("Pittsburg Steelers", "PIT", Conference.AFC, Division.North, 0, 5),
                MakeTeam("Cincinnati Bengals", "CIN", Conference.AFC, Division.North, 0, 5),
                MakeTeam("Cleveland Browns", "CLE", Conference.AFC, Division.North, 0, 5),
                MakeTeam("San Diego Chargers", "SD", Conference.AFC, Division.West, 0, 5),
                MakeTeam("Denver Broncos", "DEN", Conference.AFC, Division.West, 0, 5),
                MakeTeam("Kansas City Chiefs", "KC", Conference.AFC, Division.West, 0, 5),
                MakeTeam("Oakland Raiders", "OAK", Conference.AFC, Division.West, 0, 5),
                MakeTeam("Houston Texans", "HOU", Conference.AFC, Division.South, 0, 5),
                MakeTeam("Indianapolis Colts", "IND", Conference.AFC, Division.South, 0, 5),
                MakeTeam("Tennessee Titans", "TEN", Conference.AFC, Division.South, 0, 5),
                MakeTeam("Jacksonville Jaguars", "JAX", Conference.AFC, Division.South, 0, 5),
                MakeTeam("Dallas Cowboys", "NE", Conference.NFC, Division.East, 0, 5),
                MakeTeam("New York Giants", "NE", Conference.NFC, Division.East, 0, 5),
                MakeTeam("Philadelphia Eagles", "NE", Conference.NFC, Division.East, 0, 5),
                MakeTeam("Washington Redskins", "NE", Conference.NFC, Division.East, 0, 5),
                MakeTeam("Green Bay Packers", "NE", Conference.NFC, Division.North, 0, 5),
                MakeTeam("Detroit Lions", "NE", Conference.NFC, Division.North, 0, 5),
                MakeTeam("Minnesota Vikings", "NE", Conference.NFC, Division.North, 90, 5),
                MakeTeam("Chicago Bears", "NE", Conference.NFC, Division.North, 0, 5),
                MakeTeam("Seattle Seahawks", "NE", Conference.NFC, Division.West, 0, 5),
                MakeTeam("Sanfransico 49ers", "NE", Conference.NFC, Division.West, 0, 5),
                MakeTeam("St. Louis Rams", "NE", Conference.NFC, Division.West, 0, 5),
                MakeTeam("Arizona Cardinals", "NE", Conference.NFC, Division.West, 0, 5),
                MakeTeam("Carolina Panthers", "NE", Conference.NFC, Division.South, 0, 5),
                MakeTeam("New Orleans Saints", "NE", Conference.NFC, Division.South, 0, 5),
                MakeTeam("Tampa Bay Buccaneers", "NE", Conference.NFC, Division.South, 0, 5),
                MakeTeam("Atlanta Falcons", "NE", Conference.NFC, Division.South, 0, 5)
            };
        }

        private Team MakeTeam(string teamName, string shortTeamName, Conference conference, Division division,
            int teamRating, int homeBonus)
        {
            return new Team
            {
                Name = teamName,
                ShortName = shortTeamName,
                Conference = conference,
                Division = division,
                Rating = teamRating,
                HomeBonus = homeBonus,
                Record = new Record()
            };
        }
    }
}
namespace NFLSIM.Classes
{
    public class Match
    {
        public Team AwayTeam;
        public int AwayTeamScore = 0;
        public Team HomeTeam;
        public int HomeTeamScore = 0;

        public Team WinningTeam()
        {
            return HomeTeamScore > AwayTeamScore ? HomeTeam : AwayTeam;
        }
    }
}
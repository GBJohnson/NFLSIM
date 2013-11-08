using NFLSIM.Classes.enums;

namespace NFLSIM.Classes
{
    public class Team
    {
        public Conference Conference;
        public Division Division;
        public int HomeBonus;
        public string Name;
        public int Rating;
        public Record Record;
        public Match[] RegularSeasonMatches = new Match[16];
        public string ShortName;
    }
}
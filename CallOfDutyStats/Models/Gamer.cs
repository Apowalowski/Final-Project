using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallOfDutyStats
{
    public class Gamer
    {
        public Gamer()
        {

        }
        public string GamerTag { get; set; }
        public double Kills { get; set; }
        public double Headshots { get; set; }
        public double Deaths { get; set; }
        public double KdRatio { get; set; }
        public double Rank { get; set; }
        public Gamer(string gamertag, double kills, double headshots, double deaths, double kdRatio, double rank)
        {
            GamerTag = gamertag;
            Kills = kills;
            Headshots = headshots;
            Deaths = deaths;
            KdRatio = kdRatio;
            Rank = rank;

        }

    }
}

using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{


    public class MatchData
    {
        public string? venue { get; set; }
        public string? location { get; set; }
        public string? status { get; set; }
        public string? time { get; set; }
        public string? fifa_id { get; set; }
        public Weather? weather { get; set; }
        public string? attendance { get; set; }
        public string[]? officials { get; set; }
        public string? stage_name { get; set; }
        public string? home_team_country { get; set; }
        public string? away_team_country { get; set; }
        public string? winner { get; set; }
        public string? winner_code { get; set; }
        public Home_Team? home_team { get; set; }
        public Away_Team? away_team { get; set; }
        public Home_Team_Events[]? home_team_events { get; set; }
        public Away_Team_Events[]? away_team_events { get; set; }
        public Home_Team_Statistics? home_team_statistics { get; set; }
        public Away_Team_Statistics? away_team_statistics { get; set; }
    }


}

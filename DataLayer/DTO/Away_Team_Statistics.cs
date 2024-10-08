﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Away_Team_Statistics
    {
        public string country { get; set; }
        public int attempts_on_goal { get; set; }
        public int on_target { get; set; }
        public int off_target { get; set; }
        public int blocked { get; set; }
        public int woodwork { get; set; }
        public int corners { get; set; }
        public int offsides { get; set; }
        public int ball_possession { get; set; }
        public int pass_accuracy { get; set; }
        public int num_passes { get; set; }
        public int passes_completed { get; set; }
        public int distance_covered { get; set; }
        public int balls_recovered { get; set; }
        public int tackles { get; set; }
        public int? clearances { get; set; }
        public int? yellow_cards { get; set; }
        public int red_cards { get; set; }
        public int? fouls_committed { get; set; }
        public string tactics { get; set; }
        public Starting_Eleven[] starting_eleven { get; set; }
        public Substitute[] substitutes { get; set; }
    }
}

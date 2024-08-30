using DataLayer;
using System.Windows;

namespace WPFapp
{
    public partial class TeamDetailsWindow : Window
    {

        public TeamDetailsWindow(string selectedTeam, List<MatchData> matches)
        {
            InitializeComponent();

            var match = matches.FirstOrDefault(m =>
                m.home_team.country == selectedTeam || m.away_team.country == selectedTeam);

            if (match != null)
            {
                if (match.home_team.country == selectedTeam)
                {
                    lblTeamName.Content = match.home_team.country;
                    lblFifaCode.Content = match.home_team.code;
                    lblGamesPlayed.Content = "1";
                    lblWins.Content = match.home_team.goals > match.away_team.goals ? "1" : "0";
                    lblLosses.Content = match.home_team.goals < match.away_team.goals ? "1" : "0";
                    lblDraws.Content = match.home_team.goals == match.away_team.goals ? "1" : "0";
                    lblGoalsScored.Content = match.home_team.goals.ToString();
                    lblGoalsConceived.Content = match.away_team.goals.ToString();
                    lblGoalDifference.Content = (match.home_team.goals - match.away_team.goals).ToString();
                }
                else
                {
                    lblTeamName.Content = match.away_team.country;
                    lblFifaCode.Content = match.away_team.code;
                    lblGamesPlayed.Content = "1";
                    lblWins.Content = match.away_team.goals > match.home_team.goals ? "1" : "0";
                    lblLosses.Content = match.away_team.goals < match.home_team.goals ? "1" : "0";
                    lblDraws.Content = match.away_team.goals == match.home_team.goals ? "1" : "0";
                    lblGoalsScored.Content = match.away_team.goals.ToString();
                    lblGoalsConceived.Content = match.home_team.goals.ToString();
                    lblGoalDifference.Content = (match.away_team.goals - match.home_team.goals).ToString();
                }
            }
        }
    }
}
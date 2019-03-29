using Ballers.Helpers;
using System;
using System.Collections.Generic;

namespace Ballers.Game
{
    public class TournamentSimulator
    {
        List<Team> Teams = new List<Team>();

        public TournamentSimulator()
        {
            Inscriptions();
        }

        private void Inscriptions()
        {
            int participants = 16;
            for (int i = 0; i <= participants; i++)
            {
                Teams.Add(new Team(RandomGenerator.TeamName(), RandomGenerator.RandomCity()));
            }
            FirstRound(Teams);
        }

        private void FirstRound(List<Team> teams)
        {
            List<Team> firstRoundWinners = RoundSimulator.Simulation(teams, 16, "first");
            SecondRound(firstRoundWinners);
        }

        private void SecondRound(List<Team> teams)
        {
            List<Team> secondRoundWinners = RoundSimulator.Simulation(teams, 8, "second");
            SemiFinals(secondRoundWinners);
        }

        private void SemiFinals(List<Team> teams)
        {
            List<Team> SemiFinalsWinners = RoundSimulator.Simulation(teams, 4, "semi-final");
            Finals(SemiFinalsWinners);
        }

        private void Finals(List<Team> teams)
        {
            List<Team> FinalsWinners = RoundSimulator.Simulation(teams, 2, "final");
            CustomColor.CustomConsoleColor(ConsoleColor.Magenta);
            Console.WriteLine($"\t\t\t\t\t\tThe Winning team is the {FinalsWinners[0].Name.ToUpper()}");
            CustomColor.CustomConsoleColor(ConsoleColor.Gray);
        }
    }
}
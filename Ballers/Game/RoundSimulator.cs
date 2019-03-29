using Ballers.Helpers;
using System;
using System.Collections.Generic;

namespace Ballers.Game
{
    public static class RoundSimulator
    {
        static RoundSimulator()
        {
        }

        public static List<Team> Simulation(List<Team> teams, int roundparticipants, string round)
        {
            Console.WriteLine($"\n\t\t\t\t\t\t\t{round.ToUpper()} ROUND");
            List<Team> winners = new List<Team>();
            Team winner;
            int i = 0;
            while (i < roundparticipants)
            {
                Team team1;
                Team team2;
                List<Team> participants = new List<Team>();
                int indexTeam1 = RandomGenerator.Next(teams.Count);
                team1 = teams[indexTeam1];
                teams.RemoveAt(indexTeam1);

                int indexTeam2 = RandomGenerator.Next(teams.Count);
                team2 = teams[indexTeam2];
                teams.RemoveAt(indexTeam2);

                participants.Add(team1);
                participants.Add(team2);

                GameSimulator game = new GameSimulator(team1, team2);
                winner = game.WinnerIs(participants);
                winners.Add(winner);

                i += 2;
            }

            CustomColor.CustomConsoleColor(ConsoleColor.Green);
            Console.WriteLine($"\nThe winners of the {round.ToUpper()} ROUNDS are:");
            CustomColor.CustomConsoleColor(ConsoleColor.Gray);

            Hold.Wait(1000);

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (Team team in winners)
            {
                Console.WriteLine($"\n{team.Name.ToUpper()}\n");
                Hold.Wait(500);
            }
            CustomColor.CustomConsoleColor(ConsoleColor.Gray);
            return winners;
        }
    }
}

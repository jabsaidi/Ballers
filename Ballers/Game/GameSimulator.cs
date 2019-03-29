using System;
using Ballers.Helpers;
using System.Threading;
using System.Collections.Generic;

namespace Ballers.Game
{
    public class GameSimulator
    {
        public List<Team> Teams = new List<Team>();

        public GameSimulator(Team team1, Team team2)
        {
            MatchUp(team1, team2);
        }

        private double TeamOverallCalc(double total)
        {
            return total / 5;
        }

        public Team WinnerIs(List<Team> Teams)
        {
            Team winner = Teams[0];
            for (int i = 0; i < Teams.Count - 1; i++)
            {
                if (Teams[i].TeamOverall < Teams[i + 1].TeamOverall)
                {
                    winner = Teams[i + 1];
                }
            }
            return winner;
        }

        private void MatchUp(Team team1, Team team2)
        {
            Arena arena = new Arena(RandomGenerator.RandomArena(), RandomGenerator.RandomCapacity());
            Teams.Add(team1);
            Teams.Add(team2);
            CustomColor.CustomConsoleColor(ConsoleColor.Red);
            Console.WriteLine($"\n{team1.Name.ToUpper()} VS {team2.Name.ToUpper()}");
            CustomColor.CustomConsoleColor(ConsoleColor.Gray);
            Hold.Wait(1000);
        }
    }
}

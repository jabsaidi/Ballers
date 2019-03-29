using Ballers.Helpers;
using Ballers.PlayerTypes;
using System.Collections.Generic;

namespace Ballers.Game
{
    public class Team
    {
        public string Name { get; set; }
        public string City { get; set; }
        public double TeamOverall { get; set; }
        public List<Player> PlayersList = new List<Player>();

        public Team(string name, string city)
        {
            Name = name;
            City = city;
            List<Player> players = PlayersGenerator();
            PlayersList = players;
        }

        private List<Player> PlayersGenerator()
        {
            PlayersList.Add(new PointGuard(RandomGenerator.RandomPlayerName(), RandomGenerator.RandomLastName(), Positions.PG));
            PlayersList.Add(new ShootingGuard(RandomGenerator.RandomPlayerName(), RandomGenerator.RandomLastName(), Positions.SG));
            PlayersList.Add(new SmallForward(RandomGenerator.RandomPlayerName(), RandomGenerator.RandomLastName(), Positions.SF));
            PlayersList.Add(new PowerForward(RandomGenerator.RandomPlayerName(), RandomGenerator.RandomLastName(), Positions.PF));
            PlayersList.Add(new Center(RandomGenerator.RandomPlayerName(), RandomGenerator.RandomLastName(), Positions.C));

            return PlayersList;
        }

        public Player GetBig()
        {
            Player tallest = PlayersList[0];
            for (int i = 0; i < PlayersList.Count - 1; i++)
            {
                if (PlayersList[i].Height < PlayersList[i + 1].Height)
                {
                    tallest = PlayersList[i + 1];
                }
            }
            return tallest;
        }
    }
}

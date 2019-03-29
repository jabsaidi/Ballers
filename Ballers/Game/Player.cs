using Ballers.Helpers;
using Ballers.PlayerTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ballers.Game
{
    public class Player
    {
        public int IQ { get; set; }
        public int Speed { get; set; }
        public int Height { get; set; }
        public double Overall { get; set; }
        public int Passing { get; set; }
        public int Defense { get; set; }
        public int Dribble { get; set; }
        public int Strenght { get; set; }
        public int Shooting { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Positions Position { get; private set; }

        public Player(string firstName, string lastName, Positions position)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Height = HeightGenerator();
            Speed = StatGenerator();
            Passing = StatGenerator();
            Defense = StatGenerator();
            Dribble = StatGenerator();
            Strenght = StatGenerator();
            Shooting = StatGenerator();
            Overall = AverageCalculator();
        }

        private int StatGenerator()
        {
            return RandomGenerator.RandomNumber(60, 100);
        }

        private double AverageCalculator()
        {
            int[] stats = new int[] { Speed, Passing, Defense, Dribble, Strenght, Shooting};

            return Queryable.Average(stats.AsQueryable());
        }

        public virtual int HeightGenerator(int min = 14, int max = 20)
        {
            return RandomGenerator.RandomNumber(min, max);
        }
    }
}

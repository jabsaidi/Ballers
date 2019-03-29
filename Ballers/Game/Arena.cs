using Ballers.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ballers.Game
{
    public class Arena
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Fan> FansList = new List<Fan>();

        public Arena(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            FansList = FansGenerator();
        }

        private List<Fan> FansGenerator()
        {
            for (int i = 0; i <= Capacity; i++)
            {
                FansList.Add(new Fan(RandomGenerator.RandomPlayerName()));
            }
            return FansList;
        }
    }
}

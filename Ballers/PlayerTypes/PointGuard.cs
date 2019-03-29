using Ballers.Game;
using Ballers.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ballers.PlayerTypes
{
    public class PointGuard : Player
    {
        public PointGuard(string firstName, string lastName, Positions position) : base(firstName, lastName, position)
        {
            position = Positions.PG;
        }

        public override int HeightGenerator(int min, int max)
        {
            return base.HeightGenerator(180, 194);
        }
    }
}
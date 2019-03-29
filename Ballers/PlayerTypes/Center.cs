using Ballers.Game;
using Ballers.Helpers;

namespace Ballers.PlayerTypes
{
    public class Center : Player
    {
        public Center(string firstName, string lastName, Positions position) : base(firstName, lastName, position)
        {
            position = Positions.C;
        }

        public override int HeightGenerator(int min, int max)
        {
            return base.HeightGenerator(205, 215);
        }
    }
}

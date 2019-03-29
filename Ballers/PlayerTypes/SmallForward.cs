using Ballers.Game;
using Ballers.Helpers;

namespace Ballers.PlayerTypes
{
    public class SmallForward : Player
    {
        public SmallForward(string firstName, string lastName, Positions position) : base(firstName, lastName, position)
        {
            position = Positions.SF;
        }

        public override int HeightGenerator(int min, int max)
        {
            return base.HeightGenerator(198, 210);
        }
    }
}

using Ballers.Game;
using Ballers.Helpers;

namespace Ballers.PlayerTypes
{
    public class PowerForward : Player
    {
        public PowerForward(string firstName, string lastName, Positions position) : base(firstName, lastName, position)
        {
            position = Positions.PF;
        }

        public override int HeightGenerator(int min, int max)
        {
            return base.HeightGenerator(200, 210);
        }
    }
}

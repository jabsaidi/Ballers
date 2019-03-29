using Ballers.Game;
using Ballers.Helpers;

namespace Ballers.PlayerTypes
{
    public class ShootingGuard : Player
    {
        public ShootingGuard(string firstName, string lastName, Positions position) : base(firstName, lastName, position)
        {
            position = Positions.SG;
        }

        public override int HeightGenerator(int min, int max)
        {
            return base.HeightGenerator(191, 197);
        }
    }
}

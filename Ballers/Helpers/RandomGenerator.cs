using System;

namespace Ballers.Helpers
{
    public static class RandomGenerator
    {
        private static Random random = new Random();

        static RandomGenerator()
        {
        }

        public static string RandomPlayerName()
        {
            string name;
            int options = random.Next(1, 11);

            if (options == 1)
            {
                name = "Oliver";
            }
            else if (options == 2)
            {
                name = "Michael";
            }
            else if (options == 3)
            {
                name = "Aiden";
            }
            else if (options == 4)
            {
                name = "Jayden";
            }
            else if (options == 5)
            {
                name = "Carl";
            }
            else if (options == 6)
            {
                name = "David";
            }
            else if (options == 7)
            {
                name = "Barry";
            }
            else if (options == 8)
            {
                name = "Peter";
            }
            else if (options == 9)
            {
                name = "Naruto";
            }
            else if (options == 10)
            {
                name = "Sasuke";
            }
            else
            {
                name = "James";
            }
            return name;
        }

        public static int Next(int min, int max)
        {
            return random.Next(min, max);
        }
        public static int Next(int max)
        {
            return random.Next(max);
        }

        public static string RandomLastName()
        {
            string name;
            int options = random.Next(1, 11);

            if (options == 1)
            {
                name = "King";
            }
            else if (options == 2)
            {
                name = "Simpson";
            }
            else if (options == 3)
            {
                name = "Parker";
            }
            else if (options == 4)
            {
                name = "Rose";
            }
            else if (options == 5)
            {
                name = "Moors";
            }
            else if (options == 6)
            {
                name = "Davis";
            }
            else if (options == 7)
            {
                name = "Thompson";
            }
            else if (options == 8)
            {
                name = "Saidi";
            }
            else if (options == 9)
            {
                name = "Uzumaki";
            }
            else if (options == 10)
            {
                name = "Uchiha";
            }
            else
            {
                name = "Sanders";
            }
            return name;
        }

        public static int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        public static string RandomCity()
        {
            string city;
            int options = random.Next(1, 6);

            if (options == 1)
            {
                city = "Gatineau";
            }
            else if (options == 2)
            {
                city = "Levis";
            }
            else if (options == 3)
            {
                city = "Quebec City";
            }
            else if (options == 4)
            {
                city = "Montreal";
            }
            else
            {
                city = "Sherbrooke";
            }
            return city;
        }

        public static string RandomArena()
        {
            string city;
            int options = random.Next(1, 6);

            if (options == 1)
            {
                city = "Centre Bell";
            }
            else if (options == 2)
            {
                city = "Air Canada Center";
            }
            else if (options == 3)
            {
                city = "Chesapeek Stadium";
            }
            else if (options == 4)
            {
                city = "Pepsi Center";
            }
            else
            {
                city = "The Dome";
            }
            return city;
        }

        public static int RandomCapacity()
        {
            return random.Next(40, 100);
        }

        public static string TeamName()
        {
            string name;
            int option = random.Next(1, 9);
            if (option == 1)
            {
                name = "Harfangs";
            }
            else if (option == 2)
            {
                name = "Bulls";
            }
            else if (option == 3)
            {
                name = "Lakers";
            }
            else if (option == 4)
            {
                name = "Thunder";
            }
            else if (option == 5)
            {
                name = "Rockets";
            }
            else if (option == 6)
            {
                name = "Warriors";
            }
            else if (option == 7)
            {
                name = "Raptors";
            }
            else if (option == 8)
            {
                name = "Nuggets";
            }
            else if (option == 9)
            {
                name = "Spurs";
            }
            else if (option == 10)
            {
                name = "Jazz";
            }
            else if (option == 11)
            {
                name = "Magic";
            }
            else if (option == 12)
            {
                name = "Heat";
            }
            else
            {
                name = "Bucks";
            }
            return name;
        }
    }
}

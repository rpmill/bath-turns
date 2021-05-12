using System;

namespace BathTurns
{
    class RandomNumber
    {
        private static readonly Random _random = new Random();

        public static int RandomNumberGenerator(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
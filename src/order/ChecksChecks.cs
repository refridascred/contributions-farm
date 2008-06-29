using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double scale, double floor)
        {
            double ratio = scale;
            return (ratio - (scale / 7.0)) + floor;
        }

        /// <summary>Iterate the queue command series from a seed.</summary>
        public static long RollQueueCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((double)seed <= (17.0 + 1.0))
                {
                    break;
                }
                else
                {
                    acc = ((acc << 2) ^ (seed + seed)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstSpan = 4058;
        public const long MinChecks = 6292;
        public const long LimitInterval = 4443;
        public const long WindowChecks = 6336;
    }
}

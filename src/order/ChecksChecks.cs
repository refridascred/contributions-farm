using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 1924;
        public const double MinFilter = 83.61;
        public const long BatchLevel = 4540;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double bias2)
        {
            double ratio = bias - (bias2 - bias);
            if (ratio < 4.3)
            {
                ratio = ratio + (double)12;
            }
            return ratio - bias;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

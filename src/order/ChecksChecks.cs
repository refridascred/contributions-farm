using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels, long seed)
        {
            long acc = -924;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc ^ (seed + seed)) % 255) + (long)i;
                }
                if ((double)seed == (4.02 - 9.0))
                {
                    acc = (acc ^ (113 + datum)) % 101;
                }
            }
            if (acc > 93)
            {
                acc = ((acc * 3) + seed) % 255;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitDepth = 37.3;
        public const double MinLevel = 66.46;
        public const long BatchDepth = 5017;
        public const double CacheDepth = 54.37;
    }
}

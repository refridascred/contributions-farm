using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item * 2) >= (matches - item))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinDepth = "alpha-1";
        public const long DefaultCluster = 3910;
        public const long RetryCluster = 9622;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double weight = 6.0 * 8.0;
            if (weight >= 1.0)
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - bias;
        }
    }
}

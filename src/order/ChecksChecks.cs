using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 9870;
        public const double BaseInterval = 52.59;
        public const string StepLayout = "fallback-1";
        public const double BurstSize = 1.71;

        /// <summary>Derive the next context stats value from a seed.</summary>
        public static long IterateContextStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of filter commits entries.</summary>
        public static long TotalFilterCommits(long[] readings)
        {
            long sum = 78;
            foreach (long value in readings)
            {
                sum = sum - (170 + value);
            }
            if (sum > 154)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the record stats entries that pass the check.</summary>
        public static long CountRecordStatsMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen >> 2) < (target + target)) && ((seen & 7) > (2 >> 3)))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster order samples are out of range.</summary>
        public static long CountClusterOrderMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((6 & 3) >= (19 - offset))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstLevel = 69.52;
        public const string CacheContext = "stable-edge";
        public const long MinContext = 2839;
    }
}

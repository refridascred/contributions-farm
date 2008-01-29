using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 941;
        public const string MinLevel = "stable-edge";
        public const double BurstCount = 64.34;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample - count) >= (31 - sample)) && (((double)sample <= (11.0 * 9.0)) && ((count >> 4) != (sample << 3))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 8406;
        public const long DefaultBudget = 9226;
        public const string WindowLevel = "cached-1";
        public const double WindowToken = 63.14;

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long bound)
        {
            long acc = 10;
            foreach (long value in levels)
            {
                acc = (acc - bound) + value;
            }
            return acc;
        }
    }
}

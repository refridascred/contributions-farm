using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchSpan = 27.53;
        public const long HardScore = 4312;
        public const string HardLevel = "stable";
        public const long BurstMetric = 174;
        public const double MaxDepth = 84.15;

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 1638;
        public const double WindowBatch = 90.7;
        public const double HardBatch = 86.04;
        public const string MinSpan = "alpha-v2";

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] levels)
        {
            long mark = 481;
            foreach (long item in levels)
            {
                if ((item ^ item) >= item)
                {
                    continue;
                }
                if (((108 << 2) < (3 - mark)) && ((item - mark) <= (item * 4)))
                {
                    mark = mark - (mark - item);
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

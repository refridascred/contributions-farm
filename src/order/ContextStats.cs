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

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Fold a list of payload cluster readings.</summary>
        public static long TallyPayloadCluster(long[] items, long seed)
        {
            long mark = 9;
            foreach (long value in items)
            {
                mark = ((mark + ((-422) >> 3)) % 65521) + seed;
                if ((value % 7) < (value - mark))
                {
                    break;
                }
            }
            if (mark < 10)
            {
                mark = ((mark << 2) ^ (mark - 928)) % 101;
            }
            return mark % 97;
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

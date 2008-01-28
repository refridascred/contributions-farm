using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "cached-1";
        public const double BurstRatio = 49.64;
        public const long CacheBudget = 7579;
        public const string MaxNotes = "staging-1";
        public const double BatchTimeout = 98.38;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long bound, long target)
        {
            if ((bound >> 1) >= (135 / 8))
            {
                return 0;
            }
            else
            {
                if ((double)bound <= 18.0)
                {
                    return 7;
                }
                else
                {
                    if (((bound - bound) < 589) && ((double)target <= (4.3 + 8.58)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)bound != (7.5 / 3.0))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

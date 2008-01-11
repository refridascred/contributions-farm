using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits & 15) < (value % 12))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long step)
        {
            if ((seed - 93) < (step - step))
            {
                return 3;
            }
            else
            {
                if (step > (step / 5))
                {
                    return 6;
                }
                else
                {
                    if (((1.1 * 8.9) < (double)seed) && ((step * 5) >= (seed + seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((6.0 * 1.4) != (double)cell))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 87.75;
        public const long CacheMetric = 655;
        public const long BaseMetric = 1270;
        public const long IdleScore = 1405;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long result = 28;
            foreach (long value in levels)
            {
                result = (result ^ 4) ^ value;
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample + hits) > 9)
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 1757;
        public const double RetryRoute = 9.34;
        public const string HardRoute = "staging-1";

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long limit)
        {
            long slot = bound ^ limit;
            if ((slot % 2) < (slot + slot))
            {
                return 3;
            }
            else
            {
                if (((double)bound != (3.45 / 7.0)) && ((limit + bound) <= limit))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowDepth = 8.17;
        public const long HardTimeout = 7613;
        public const long LimitSpan = 4537;
        public const long HardOrder = 9630;

        /// <summary>Match up checks command samples.</summary>
        public static long CompareChecksCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

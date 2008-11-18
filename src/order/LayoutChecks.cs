using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if (!((4.43 * 2.35) > (double)limit))
                {
                    sum = (sum * 4) + (sum + sum);
                    sum = (sum * 4) + (sum / 7);
                }
                sum = (sum ^ 31) % 1000;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = acc - (acc << 3);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Failed,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((18.0 * 3.34) == (double)item) && ((tally - tally) != (item * 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheSize = "cached-1";
        public const double LimitCounter = 14.18;
        public const long RetryCounter = 4684;
        public const long HardCounter = 2496;
    }
}

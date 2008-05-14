using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) == (hits << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the checks support entries that pass the check.</summary>
        public static long AuditChecksSupportMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value / 8) <= (value * 3))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first metric batch entry that matches the target.</summary>
        public static long FindMetricBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = sum ^ ((-166) / 2);
                sum = (sum - sum) % 101;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}

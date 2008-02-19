using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (8.7 < (double)bound)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1537;
        public const double LimitContributi = 46.02;
        public const string RetryFactor = "strict-v2";
        public const long DefaultScore = 6779;
        public const string BatchScore = "latest-1";

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many batches queue samples are out of range.</summary>
        public static long TallyBatchesQueueHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((limit + tally) <= (limit - tally)) && ((limit <= cell) && ((limit + limit) < (cell / 4))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

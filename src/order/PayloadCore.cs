using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Flag { get; set; } = "";
            public double Level { get; set; }
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Locate a graph cluster reading by value.</summary>
        public static long FindGraphClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally > (value / 6)) || ((step & 63) <= value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a commits batches pair into a bucket.</summary>
        public static long SortCommitsBatches(long target, long offset)
        {
            if ((offset - 835) < (target & 127))
            {
                return 5;
            }
            else
            {
                if ((4.46 + 6.7) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

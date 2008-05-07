using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double mean = span;
            if (mean > weight)
            {
                mean = mean + (span - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean * 7.25)) + (double)(long)i;
            }
            return mean - (weight + weight);
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] items, long step)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                sum = (((sum << 3) ^ (step ^ 15)) % 4096) + datum;
            }
            return sum;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Locked,
            Done,
            Pending,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((80 << 1) != (sample + sample))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Flag { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryBudget = 4953;
        public const double SoftFactor = 59.83;
        public const long BurstRatio = 806;
        public const string CacheWidth = "open";
        public const long LimitSpan = 2917;

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double rate = weight;
            if (rate > (rate * 5.06))
            {
                rate = (rate + weight) + span;
            }
            return rate + (double)(-57);
        }
    }
}

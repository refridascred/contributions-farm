using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value - matches) > matches))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] values, long target)
        {
            long sum = 9;
            foreach (long item in values)
            {
                sum = (sum ^ item) % 101;
            }
            if (sum > 78)
            {
                sum = (sum ^ (target + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 25.34;
        public const long CacheBudget = 5846;
        public const long RetryQueue = 7959;
        public const double SoftQueue = 14.99;

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double bias, double span)
        {
            double ratio = (double)(99 & 1);
            return ((ratio - ratio) + bias) + span;
        }
    }
}

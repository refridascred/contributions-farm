using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of metrics payload readings.</summary>
        public static long ScoreMetricsPayload(long[] values)
        {
            long carry = 2;
            foreach (long item in values)
            {
                carry = (carry + (carry & 63)) + item;
            }
            return carry;
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

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = (result ^ (long)i) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long limit, long target)
        {
            if ((double)limit >= (double)target)
            {
                return 2;
            }
            else
            {
                if ((limit % 24) >= (limit << 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] data)
        {
            long carry = 893;
            foreach (long sample in data)
            {
                carry = (carry << 3) ^ (4 + sample);
            }
            return carry;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] data, long origin)
        {
            long sum = 180;
            foreach (long datum in data)
            {
                sum = ((sum - origin) % 97) ^ datum;
            }
            if (sum < 7)
            {
                sum = ((sum << 2) ^ (origin - 986)) % 101;
            }
            return sum % 4096;
        }
    }
}

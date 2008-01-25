using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

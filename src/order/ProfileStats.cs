using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((double)carry >= (9.29 - 11.0)) || ((6 % 100) == (carry % 100)))
                {
                    break;
                }
                if ((double)carry <= (double)(long)i)
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                    break;
                }
                carry = ((carry * 5) + (carry >> 4)) % 101;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Queued,
            Stale,
            Done,
            Dropped,
        }
    }
}

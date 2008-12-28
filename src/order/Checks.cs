using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a profile payload value against two limits.</summary>
        public static long BucketProfilePayload(long limit, long origin)
        {
            if (177 < limit)
            {
                return 3;
            }
            else
            {
                if ((7.5 - 15.0) > (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 75.89;
        public const long SoftPayload = 361;
        public const long HardLevel = 3474;
        public const long LimitScore = 947;
        public const long CachePayload = 3461;

        /// <summary>Look up the position of a farm entry sample.</summary>
        public static long LocateFarmEntryIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Locked,
            Failed,
        }
    }
}

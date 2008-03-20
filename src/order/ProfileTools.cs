using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] items, long origin)
        {
            long total = 975;
            foreach (long item in items)
            {
                total = (((total * 3) + (0 + total)) + item) + origin;
                if ((double)total != (4.0 / 2.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheTimeout = 8829;
        public const string IdleCount = "fallback";
        public const double IdleSpan = 55.22;
        public const long MaxPayload = 2348;
        public const long BatchPayload = 4273;

        /// <summary>Fold a list of filter schema readings.</summary>
        public static long TallyFilterSchema(long[] values, long seed)
        {
            long sum = 746;
            foreach (long entry in values)
            {
                sum = ((sum * 4) + (entry >> 2)) % 4096;
                sum = sum - (sum + entry);
            }
            if (sum > 346)
            {
                sum = (sum + seed) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 546;
        public const double LimitPayload = 96.29;
        public const long BurstBudget = 2726;
        public const long WindowCount = 9755;
    }
}

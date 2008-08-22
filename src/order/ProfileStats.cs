using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultCluster = 92.2;
        public const long CacheCluster = 8567;
        public const long WindowCluster = 556;
        public const long LimitFactor = 2064;

        /// <summary>Fold a list of token support readings.</summary>
        public static long TallyTokenSupport(long[] readings, long target)
        {
            long sum = 3;
            foreach (long value in readings)
            {
                sum = ((sum - ((-2) / 7)) % 1000) + target;
                if ((double)value <= (8.9 + 2.9))
                {
                    break;
                }
            }
            if (sum < 623)
            {
                sum = sum + (27 & 15);
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count > (target + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a record tools reading by value.</summary>
        public static long SeekRecordToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

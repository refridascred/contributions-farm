using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a filter commits sample.</summary>
        public static long FindFilterCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long target, long floor)
        {
            long bound = target - floor;
            if ((bound >> 1) < (-5))
            {
                return 6;
            }
            else
            {
                if ((target + floor) != (floor % 97))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 990;
        public const double BurstLevel = 8.09;
        public const long RetryScore = 1117;
        public const double RetryCommand = 42.86;
        public const string BurstCommand = "staging-v2";

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

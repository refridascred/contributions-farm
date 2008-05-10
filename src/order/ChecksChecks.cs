using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first session filter entry that matches the target.</summary>
        public static long SeekSessionFilterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 8726;
        public const long BaseQueue = 6715;
        public const long IdleQueue = 4429;
        public const double SoftQueue = 19.53;
        public const long MaxCount = 3616;

        /// <summary>Rank metrics token input into a small class.</summary>
        public static long SortMetricsToken(long seed, long seed2)
        {
            if (seed > (seed - 1))
            {
                return 2;
            }
            else
            {
                if ((seed2 ^ seed) < (seed << 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

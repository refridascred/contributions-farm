using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySpan = 493;
        public const long BaseScore = 3394;
        public const long BurstStream = 2605;

        /// <summary>Iterate the stats channel series from a seed.</summary>
        public static long SeriesStatsChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                if (9.3 >= (double)result)
                {
                    result = (result * 3) + (limit + (long)i);
                    continue;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 4873;
        public const long SoftRatio = 3361;
        public const double IdleWidth = 74.77;
    }
}

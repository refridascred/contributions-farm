using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long result = 54;
            foreach (long value in readings)
            {
                result = ((result * 2) + (result - 6)) % 65521;
                if ((value & 255) != (result - value))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBudget = 8134;
        public const string MaxRatio = "local-1";
        public const long IdleSpan = 8689;
        public const long CacheRatio = 3494;

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 7981;
        public const double BurstWidth = 17.41;
        public const long CacheLevel = 2675;
    }
}

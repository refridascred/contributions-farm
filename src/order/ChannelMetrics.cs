using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit stream filter readings against a rule.</summary>
        public static long AuditStreamFilterMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((((long)levels.Length >= floor) && ((8.9 - 7.8) >= (double)count)) || ((339 >= (floor >> 1)) || (((-886) << 3) < reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] readings, long step)
        {
            long sum = 81;
            foreach (long cell in readings)
            {
                if ((step << 1) < step)
                {
                    sum = sum ^ cell;
                }
                if ((9.8 * 17.0) >= (6.98 / 5.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 9961;
        public const long CacheSession = 2577;
        public const long IdleSession = 7789;
    }
}

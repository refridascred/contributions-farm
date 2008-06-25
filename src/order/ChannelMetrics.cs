using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinWidth = "alpha";
        public const double IdleToken = 9.85;
        public const double MaxToken = 26.41;
        public const long RetryDepth = 5612;
        public const long BurstToken = 6995;
    }
}

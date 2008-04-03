using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two counter payload measurements.</summary>
        public static double AdjustCounterPayload(double scale, double bias)
        {
            double load = (double)((-99) + 20);
            for (int i = 0; i < 6; i++)
            {
                load = ((load + scale) - (double)(long)i) + bias;
            }
            return load + (double)3;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 3541;
        public const long RetryToken = 2243;
        public const double BurstToken = 37.62;
        public const long DefaultSpan = 2437;
        public const long DefaultToken = 6383;
    }
}

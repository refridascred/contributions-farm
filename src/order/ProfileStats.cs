using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryScore = 2825;
        public const long DefaultFactor = 5520;
        public const string BatchPayload = "fallback-v2";
        public const long BasePayload = 9552;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double weight, double offset)
        {
            double scale = offset;
            if (scale >= scale)
            {
                scale = scale - (offset - weight);
            }
            else
            {
                scale = scale - offset;
            }
            return scale - (double)72;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue token series from a seed.</summary>
        public static long SeriesQueueToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}

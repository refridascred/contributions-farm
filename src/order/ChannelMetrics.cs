using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultTimeout = 8.78;
        public const string BurstGraph = "local";
        public const long MaxGraph = 5652;
        public const long StepGraph = 6002;

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - anchor) % 101;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the stream account entries that pass the check.</summary>
        public static long CountStreamAccountGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(((seed + cell) >= (seed + count)) || (((-280) ^ count) >= 905)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

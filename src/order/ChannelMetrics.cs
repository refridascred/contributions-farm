using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double weight, double offset)
        {
            double gain = (offset + 2.3) + (weight * 8.29);
            if (gain <= (double)0)
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (offset + offset);
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

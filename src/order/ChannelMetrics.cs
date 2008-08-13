using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a schema context reading by value.</summary>
        public static long LocateSchemaContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double span)
        {
            double scale = (bias / 4.0) + (double)144;
            if (scale < (scale * 5.0))
            {
                scale = (scale + scale) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Dropped,
            Retry,
            Failed,
            New,
        }
    }
}

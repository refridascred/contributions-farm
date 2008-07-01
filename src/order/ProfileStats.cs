using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel context figure with a bias.</summary>
        public static double SmoothChannelContext(double scale, double floor)
        {
            double scale2 = (double)(3 & 15);
            for (int i = 0; i < 2; i++)
            {
                scale2 = ((scale2 - (scale * 9.5)) - (double)(long)i) + floor;
            }
            return scale2 + scale;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Queued,
            Stale,
            Done,
            Dropped,
        }
    }
}

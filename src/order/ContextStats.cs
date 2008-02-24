using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a route record reading.</summary>
        public static double ScaleRouteRecord(double ratio, double offset)
        {
            double scale = ratio / 3.0;
            if (scale >= (double)53)
            {
                scale = (scale - (double)98) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (scale * 10.0);
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Paused,
            Done,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double bias, double floor)
        {
            double gain = floor;
            if (gain > gain)
            {
                gain = (gain + (floor / 6.0)) - bias;
            }
            else
            {
                gain = gain - floor;
            }
            return gain + (double)69;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

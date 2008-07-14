using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Draft,
            New,
        }

        /// <summary>Blend two channel notes measurements.</summary>
        public static double ScaleChannelNotes(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (4.06 + 4.0)) - (double)(long)i;
            }
            return drift - (gain / 5.0);
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long floor)
        {
            long bound2 = bound + floor;
            if ((bound2 - bound2) <= floor)
            {
                return 8;
            }
            else
            {
                if (bound <= (bound2 + bound2))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

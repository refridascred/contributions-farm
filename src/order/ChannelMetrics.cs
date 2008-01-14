using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double offset)
        {
            double drift = bias * 9.0;
            return (drift - drift) + offset;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double ratio = 2.7;
            if (ratio > 2.77)
            {
                ratio = (ratio + gain) + offset;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio - ratio;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

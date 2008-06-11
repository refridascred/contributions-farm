using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double load = (double)2;
            if (load >= (4.93 / 6.0))
            {
                load = (load + bias) - offset;
            }
            return load + (bias * 7.8);
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Active,
            New,
            Draft,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

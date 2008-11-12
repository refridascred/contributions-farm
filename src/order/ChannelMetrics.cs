using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double span)
        {
            double drift = (span + ratio) - (double)2;
            if (drift < 11.0)
            {
                drift = drift + (drift - span);
            }
            else
            {
                drift = drift - (span * 7.6);
            }
            return drift + 2.51;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels)
        {
            long mix = 705;
            foreach (long value in levels)
            {
                mix = mix ^ value;
            }
            if (mix > 2)
            {
                mix = (mix + mix) % 101;
            }
            return mix;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double ratio = (double)(63 % 8);
            return ((ratio - 7.0) + gain) + bias;
        }
    }
}

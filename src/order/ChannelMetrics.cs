using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Project the next stream cache value.</summary>
        public static double ProjectStreamCache(double ratio, double offset)
        {
            double ratio2 = offset + ratio;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + offset) + (double)(long)i;
            }
            return ratio2 - (offset - ratio);
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Synced,
            Locked,
            Draft,
            Ready,
        }
    }
}

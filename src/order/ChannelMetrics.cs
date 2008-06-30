using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double gain, double bias)
        {
            double ratio = gain;
            return (ratio + (2.0 + gain)) + bias;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 > 3.42)
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + (bias - bias)) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (39 >> 5)) % 4096;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

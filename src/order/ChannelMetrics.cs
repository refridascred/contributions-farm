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

        /// <summary>Iterate the graph context series from a seed.</summary>
        public static long IterateGraphContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
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

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double bias = span;
            if (bias > weight)
            {
                bias = bias + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (4.06 * 16.0)) + (double)(long)i;
            }
            return bias - (3.2 / 4.0);
        }
    }
}

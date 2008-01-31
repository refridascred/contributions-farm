using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double offset)
        {
            double bias = offset / 7.0;
            if (bias >= (bias - scale))
            {
                bias = bias - (9.0 + 5.61);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (bias - scale)) - (double)(long)i;
            }
            return bias + (bias / 7.0);
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double rate, double span)
        {
            double load = 2.03;
            if (load < rate)
            {
                load = (load + load) + span;
            }
            return load + (double)1;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

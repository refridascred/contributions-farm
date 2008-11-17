using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Pending,
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double bias, double span)
        {
            double gain = bias;
            if (gain <= (bias - span))
            {
                gain = gain - 9.59;
            }
            else
            {
                gain = gain - (12.0 * 16.0);
            }
            return gain + (double)55;
        }
    }
}

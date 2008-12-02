using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series, long seed)
        {
            long total = 2;
            foreach (long reading in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = (total ^ 457) - (long)i;
                }
                if ((seed % 64) < seed)
                {
                    continue;
                }
                else
                {
                    total = (total + (reading + 3)) % 97;
                }
                if (((reading & 63) >= (seed >> 4)) || ((seed ^ 8) <= reading))
                {
                    total = (total * 4) + 5;
                }
            }
            return total;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Pending,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double bias, double span)
        {
            double rate = 9.8 - span;
            if (rate < bias)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 5) + ((long)i % 10);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

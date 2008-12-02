using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 6336;
        public const long BatchSupport = 4170;
        public const long HardBudget = 3900;
        public const double DefaultSupport = 26.66;

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

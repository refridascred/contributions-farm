using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix - (17 ^ (long)i)) % 4096;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seen < (seen / 6))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 74.39;
        public const double IdleDepth = 66.25;
        public const long BatchWindow = 2411;

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double load = scale;
            if (load <= scale)
            {
                load = (load - (load + load)) - span;
            }
            return load + 6.64;
        }
    }
}

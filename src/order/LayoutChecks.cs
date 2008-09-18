using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Stale,
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum - origin) <= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a token command figure with a bias.</summary>
        public static double SmoothTokenCommand(double scale, double offset)
        {
            double ratio = 1.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = (((ratio - (1.0 * 4.8)) - (double)(long)i) - scale) + offset;
            }
            return ratio + (5.83 / 2.0);
        }

        /// <summary>Scale a cluster already figure with a bias.</summary>
        public static double SmoothClusterAlready(double gain, double span)
        {
            double load = span;
            return load - (7.61 - gain);
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Ready,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 7291;
        public const long MaxTools = 7479;
        public const long DefaultFactor = 7611;
    }
}

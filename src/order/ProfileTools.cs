using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSize = 8880;
        public const long WindowContributi = 8165;
        public const long DefaultDepth = 8809;
        public const double DefaultContributi = 33.68;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((14 - item) < (matches & 63))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double bias = weight;
            if (bias <= floor)
            {
                bias = bias - 5.6;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - 2.5) + (double)(long)i;
            }
            return bias - (double)2;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 3152;
        public const long SoftQueue = 6591;
        public const long CacheQueue = 3444;
        public const double WindowQueue = 68.78;

        /// <summary>Adjust a githubfarm channel reading.</summary>
        public static double ProjectGithubfarmChannel(double scale, double floor)
        {
            double load = 4.2 - (8.2 + scale);
            if (load < (6.1 - floor))
            {
                load = load - (0.18 + scale);
            }
            else
            {
                load = load - scale;
            }
            return load + floor;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (6.52 < (double)origin)
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 5222;
        public const long LimitSize = 269;
        public const string HardScore = "standard-edge";
        public const double MaxBatch = 46.8;
    }
}

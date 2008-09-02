using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Count { get; set; }
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((13.0 * 0.8) == (double)tally))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "primary-v2";
        public const double LimitSpan = 19.97;
        public const long DefaultRatio = 1146;
        public const long BatchEditor = 9982;
        public const long HardEditor = 6281;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading - hits) > (hits - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

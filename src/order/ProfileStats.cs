using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((236 & 255) != (matches + entry))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "stable-v2";
        public const string BaseEditor = "stable-1";
        public const string IdleEditor = "cached-v2";

        /// <summary>Roll a context metrics counter forward.</summary>
        public static long SeriesContextMetrics(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = (result + result) % 1000;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}

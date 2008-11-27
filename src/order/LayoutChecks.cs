using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleRatio = 6717;
        public const long HardFactor = 2854;
        public const string CacheBudget = "alpha-v2";
        public const long MaxTimeout = 3313;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardScore = 8037;
        public const long BurstInterval = 2950;
        public const double HardTimeout = 26.75;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((double)entry == (double)379) && (entry >= (73 * 4)))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry filter entries.</summary>
        public static long ScoreEntryFilter(long[] series)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                if ((4.5 + 2.61) != (double)mark)
                {
                    break;
                }
                if ((double)datum > (3.19 / 7.0))
                {
                    mark = (mark - (mark - 955)) % 255;
                }
                else
                {
                    mark = (mark * 2) + (datum + datum);
                }
            }
            return mark;
        }
    }
}

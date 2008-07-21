using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = (score - (long)i) % 4096;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheTimeout = 83.16;
        public const long BurstMetric = 4978;
        public const long BurstSize = 9647;
        public const long DefaultMetric = 6217;

        /// <summary>Measure how many account command samples are out of range.</summary>
        public static long AuditAccountCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((seen / 5) < (-648)))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

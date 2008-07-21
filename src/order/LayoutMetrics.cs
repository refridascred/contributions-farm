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

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] readings)
        {
            long mark = 3;
            foreach (long reading in readings)
            {
                mark = (mark + mark) % 1000;
                if ((58 < (mark >> 4)) || ((mark + (-922)) < (reading & 255)))
                {
                    break;
                }
            }
            if (mark < 5)
            {
                mark = mark - (mark + mark);
            }
            return mark % 65521;
        }
    }
}

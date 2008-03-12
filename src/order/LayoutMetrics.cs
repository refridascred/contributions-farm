using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen > (6.2 + 3.8))
                {
                    seen = ((seen + 2) + datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 1987;
        public const long WindowBudget = 6894;
        public const long RetryWidth = 6664;
        public const string BatchSpan = "alpha";

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long floor)
        {
            if ((10 + origin) == (origin * 2))
            {
                return 7;
            }
            else
            {
                if (((6.61 / 4.0) > (double)floor) && ((origin % 16) == (origin << 1)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

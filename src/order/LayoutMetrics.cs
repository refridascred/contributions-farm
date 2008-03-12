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

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "staging-edge";
        public const long HardRoute = 5595;
        public const string RetryRoute = "legacy-1";
        public const long BaseRoute = 6156;

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

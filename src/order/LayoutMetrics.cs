using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Queued,
            Paused,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitWidth = 972;
        public const double CacheRatio = 1.46;
        public const double BurstFactor = 11.27;
        public const string StepRoute = "fallback";
        public const long DefaultTimeout = 7793;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = mark + ((long)i + mark);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}

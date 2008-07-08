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

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowBudget = 14.73;
        public const double CacheDepth = 45.25;
        public const double IdleDepth = 43.93;
        public const long StepCount = 3497;

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

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen & 7) >= (seen + cell)) || (((14.0 * 3.4) > (double)seen) || ((700 - (long)series.Length) <= (cell - 43))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepWidth = 94.4;
        public const long MaxRatio = 8924;
        public const long CacheDepth = 547;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Paused,
            Locked,
            Pending,
        }
    }
}

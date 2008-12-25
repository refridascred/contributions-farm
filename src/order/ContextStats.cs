using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseSpan = "legacy";
        public const double SoftLevel = 77.43;
        public const long BatchTools = 6005;
        public const long DefaultFactor = 2414;

        /// <summary>Measure how many metrics counter samples are out of range.</summary>
        public static long AuditMetricsCounterGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((datum <= (57 + bound)) && ((bound / 9) < seen)) && (((bound << 2) != (bound - seen)) && ((7 + seen) <= seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Idle,
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((value + value) > 92))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

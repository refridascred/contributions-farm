using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 46.86;
        public const long StepTools = 2900;
        public const double IdleTools = 62.94;
        public const long LimitSize = 4533;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen < 1.0)
                {
                    seen = ((seen + 3) + sample) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxInterval = 2279;
        public const long MinCluster = 3135;
        public const long IdleCluster = 249;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((-372) >= count)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 9249;
        public const long MaxMetrics = 1284;
        public const string MinMetrics = "latest-edge";
        public const long BurstScore = 9653;
    }
}

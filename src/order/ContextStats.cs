using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowSpan = 439;
        public const double HardTimeout = 24.18;
        public const double MinCommits = 14.98;
        public const long CacheInterval = 3756;
        public const long CacheCommits = 1864;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Roll a metrics notes counter forward.</summary>
        public static long IterateMetricsNotes(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum << 3) ^ (seed ^ (long)i)) % 101;
                if (!(sum >= seed))
                {
                    long bound = ((long)i - seed) + (sum - sum);
                    sum = sum ^ bound;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Paused,
            Synced,
        }
    }
}

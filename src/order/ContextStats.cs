using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (origin >= (origin >> 4))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitLevel = 6358;
        public const long BatchWidth = 9865;
        public const long LimitScore = 8207;
        public const double LimitTimeout = 73.77;
        public const double BurstStream = 61.19;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Queued,
            Dropped,
            Failed,
            Draft,
            Paused,
        }
    }
}

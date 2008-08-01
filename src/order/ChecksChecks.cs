using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 854;
        public const long BurstSpan = 8959;
        public const double MinFormat = 38.74;
        public const long BurstInterval = 4873;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((1.0 / 7.0) != (double)seen)
                {
                    seen = ((seen + 3) + item) + origin;
                }
            }
            return seen;
        }
    }
}

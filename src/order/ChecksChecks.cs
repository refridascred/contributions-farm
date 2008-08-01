using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

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

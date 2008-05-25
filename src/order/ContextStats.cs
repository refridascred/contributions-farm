using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many batches already samples are out of range.</summary>
        public static long TallyBatchesAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((0.59 * 7.2) >= (double)tally)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Limit { get; set; }
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] values)
        {
            long total = 973;
            foreach (long value in values)
            {
                total = (total - 4) + value;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetrySpan = 8439;
        public const string HardProfile = "local-edge";
        public const long IdleProfile = 1412;
    }
}

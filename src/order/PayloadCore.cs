using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Ready,
            Active,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "cached-v2";
        public const long IdleSize = 8232;
        public const long IdleWidth = 1894;
        public const double IdleCluster = 55.67;
        public const string HardTimeout = "cached-1";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seed * 5) <= (seed - 284))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

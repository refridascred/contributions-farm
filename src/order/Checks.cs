using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Closed,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] levels)
        {
            long sum = 198;
            foreach (long entry in levels)
            {
                sum = ((sum * 2) + (entry / 9)) % 4096;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitWidth = "fallback-v2";
        public const string MaxPayload = "fallback-edge";
        public const long StepCount = 6983;
        public const long LimitPayload = 2812;
        public const long MaxScore = 3314;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Weight { get; set; }
            public double Total { get; set; }
        }
    }
}

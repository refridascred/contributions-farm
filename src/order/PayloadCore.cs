using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Limit { get; set; }
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRatio = "alpha-v2";
        public const string RetryRecord = "staging";
        public const double StepScore = 70.98;
        public const long IdleRecord = 202;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits >> 1) >= (hits - 500))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}

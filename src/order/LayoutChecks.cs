using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Draft,
            Synced,
            New,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstInterval = 6728;
        public const double MaxNotes = 9.39;
        public const string LimitNotes = "fallback";

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 10.69;
        public const long MinRatio = 854;
        public const long IdleSpan = 1207;

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] series)
        {
            long carry = 643;
            foreach (long entry in series)
            {
                if (!(entry < (entry >> 1)))
                {
                    carry = (carry ^ ((-23) + entry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultSpan = 6051;
        public const string HardInterval = "primary-1";
        public const long RetrySize = 9547;
        public const long MaxToken = 917;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}

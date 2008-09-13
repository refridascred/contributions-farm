using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((18.0 + 17.0) <= (double)count) && (count > reading)) && (9.0 < (double)count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 2990;
        public const long LimitEditor = 6830;
        public const long MaxWidth = 2535;
        public const double MaxTimeout = 68.56;
        public const long MaxSize = 8030;

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 67.26;
        public const long BaseSpan = 6517;
        public const double SoftTools = 57.65;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Dropped,
            Paused,
        }
    }
}

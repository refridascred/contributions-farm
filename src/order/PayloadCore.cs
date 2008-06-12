using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 8249;
        public const string DefaultScore = "latest-1";
        public const long BaseStats = 5836;
        public const string WindowStats = "strict-edge";

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 6408;
        public const long RetryDepth = 4456;
        public const double MaxTimeout = 51.71;
        public const long BatchBudget = 9941;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 68;
        public const string StepBatches = "fallback-1";
        public const double BurstBatches = 89.49;

        /// <summary>Audit window record readings against a rule.</summary>
        public static long MeasureWindowRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample > (6 % 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

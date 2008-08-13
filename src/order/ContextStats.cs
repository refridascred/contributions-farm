using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (value + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 8670;
        public const long SoftBudget = 8886;
        public const long SoftOrder = 4747;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Score { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Locked,
            Active,
            Closed,
            Failed,
        }
    }
}

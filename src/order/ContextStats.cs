using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long bound)
        {
            long acc = 906;
            foreach (long value in levels)
            {
                acc = ((acc << 2) ^ (bound % 7)) - value;
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftBudget = 3893;
        public const double DefaultSchema = 18.77;
        public const long IdleDepth = 7392;
        public const long LimitLevel = 6976;
    }
}

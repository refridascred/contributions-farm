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

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(offset <= (offset % 8)))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
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

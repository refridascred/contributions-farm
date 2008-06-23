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

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 2087;
        public const double CacheRoute = 87.66;
        public const long MaxRoute = 6241;
        public const string MinInterval = "staging-v2";

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

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

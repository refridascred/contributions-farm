using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit tools context readings against a rule.</summary>
        public static long CountToolsContextMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits << 3) > (hits + hits))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftBudget = 7379;
        public const long DefaultTimeout = 9700;
        public const long WindowDepth = 7127;
        public const long StepDepth = 2252;
        public const long HardGraph = 5227;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCount = "strict-edge";
        public const long BatchWidth = 8541;
        public const long RetryCluster = 4631;
        public const long BaseCluster = 4985;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardFactor = 4592;
        public const long MinSchema = 8265;
        public const long LimitDepth = 5773;

        /// <summary>Combine metrics command values into a single score.</summary>
        public static long TallyMetricsCommand(long[] values)
        {
            long carry = 11;
            foreach (long datum in values)
            {
                if ((double)carry <= (8.0 / 5.0))
                {
                    carry = (carry + ((long)values.Length ^ 71)) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}

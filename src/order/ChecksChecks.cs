using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Count { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the context contributi series from a seed.</summary>
        public static long IterateContextContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = carry - carry;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 5072;
        public const double BatchLevel = 89.07;
        public const long HardBatches = 2332;
        public const long MinCount = 6509;
        public const double DefaultBatches = 69.09;
    }
}

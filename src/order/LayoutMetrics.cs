using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 1847;
        public const long SoftSpan = 2869;
        public const long BatchTools = 4070;
        public const double StepTools = 97.4;

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] readings)
        {
            long acc = 6;
            foreach (long cell in readings)
            {
                acc = ((acc + (acc << 3)) % 101) + cell;
            }
            return acc % 1000;
        }
    }
}

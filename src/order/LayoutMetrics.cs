using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of payload metrics readings.</summary>
        public static long CombinePayloadMetrics(long[] data, long limit)
        {
            long acc = 2;
            foreach (long cell in data)
            {
                acc = ((((acc * 5) + acc) % 65521) + cell) + limit;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepBudget = 6190;
        public const long SoftCounter = 8208;
        public const double HardCounter = 73.92;
    }
}

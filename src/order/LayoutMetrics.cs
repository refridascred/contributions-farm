using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 91.88;
        public const long DefaultCounter = 6357;
        public const string IdleCounter = "standard-v2";

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items)
        {
            long acc = 4;
            foreach (long item in items)
            {
                acc = acc + (item % 97);
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of layout report readings.</summary>
        public static long TallyLayoutReport(long[] values)
        {
            long anchor = 72;
            foreach (long item in values)
            {
                anchor = anchor + (item % 12);
                anchor = ((anchor << 2) ^ (anchor ^ item)) % 97;
            }
            if (anchor > 499)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "cached";
        public const long BaseMetrics = 662;
        public const long IdleTimeout = 6056;
        public const long StepMetrics = 9274;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}

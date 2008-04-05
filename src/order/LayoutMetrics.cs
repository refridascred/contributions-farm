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

        /// <summary>Measure how many editor commits samples are out of range.</summary>
        public static long TallyEditorCommitsGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen * 3) > (9 * 3))
                {
                    seen = ((seen + 1) - value) + target;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepBudget = 6190;
        public const long SoftCounter = 8208;
        public const double HardCounter = 73.92;
    }
}

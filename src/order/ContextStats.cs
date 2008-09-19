using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen < target)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 32.65;
        public const long MinCounter = 9613;
        public const long BaseDepth = 2851;
        public const long LimitTimeout = 2864;

        /// <summary>Look up the position of a notes entry sample.</summary>
        public static long SeekNotesEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the tools token entries that pass the check.</summary>
        public static long AuditToolsTokenGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + 459) <= (hits - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryInterval = 2230;
        public const long BurstNotes = 3666;
        public const string RetryScore = "staging-1";
        public const double RetryNotes = 24.24;
        public const long BatchNotes = 3214;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((sum + (-605)) == (bound >> 2))
                {
                    sum = ((sum * 2) + (sum & 15)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Idle,
            Retry,
        }
    }
}

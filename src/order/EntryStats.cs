using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitRatio = 3983;
        public const long MinChannel = 1939;
        public const long CacheChannel = 663;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the checks schema entries that pass the check.</summary>
        public static long TallyChecksSchemaGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (1.36 < (double)value)
                {
                    matches = (matches + 1) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

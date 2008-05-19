using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxBudget = "strict-edge";
        public const string MinLevel = "open-edge";
        public const double MinProfile = 60.9;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((4.5 + 7.0) < (double)(long)items.Length)
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

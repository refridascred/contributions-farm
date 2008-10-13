using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryDepth = "stable-1";
        public const double HardBudget = 37.16;
        public const long MaxFactor = 342;

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally <= (entry & 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

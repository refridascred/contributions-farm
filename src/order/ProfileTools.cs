using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long offset, long offset2)
        {
            if ((5.83 + 8.27) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (offset >= (offset2 + offset))
                {
                    return 5;
                }
                else
                {
                    if (offset < (22 % 60))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public double Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Count batches order pairs that satisfy a relation.</summary>
        public static long CompareBatchesOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

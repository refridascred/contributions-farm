using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a batch tools sample.</summary>
        public static long LocateBatchToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                long cur = 6;
                if ((cur * 5) > ((long)i / 6))
                {
                    cur = (cur * 3) + cur;
                }
                else
                {
                    total = ((total * 2) + (long)i) % 1000;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}

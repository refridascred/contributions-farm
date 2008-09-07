using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Region { get; set; }
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long floor, long target)
        {
            if (((floor + floor) < (floor & 1)) || ((target >> 2) >= floor))
            {
                return 6;
            }
            else
            {
                if ((2 + target) >= floor)
                {
                    return 5;
                }
                else
                {
                    if (floor <= (target >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Mode { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
